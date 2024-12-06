using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Tischprojekt.Data.obj.globals
{
    internal class _Bestellung
    {
        public int BestellNr { get; set; }
        public List<Artikel> ArtikelBasket { get; set; }

        private bool Abgeschlossen = false;

        public _Bestellung()
        {
            ArtikelBasket = new List<Artikel>();
        }

        public void AddArtikel(string artikelName, string farbe, int menge)
        {
            ArtikelBasket.Add(new Artikel(artikelName, farbe, menge));
        }

        public override string ToString()
        {
            return $"Bestellung {BestellNr}: {string.Join(", ", ArtikelBasket)}";
        }

        public bool SaveToDatabase()
        {
            if (ArtikelBasket.Count == 0 || ArtikelBasket.Count > 2)
            {
                throw new InvalidOperationException("Eine Bestellung muss mindestens 1 und maximal 2 Artikel enthalten.");
            }

            var cm = ConnectionManager.GetInstance();

            try
            {


                // Basis-SQL für die Tabelle
                string query = @"
                    INSERT INTO Bestellungen 
                    (BestellNr, Farbe_1, Farbe_2, Farbe_1_menge, Farbe_2_menge) 
                    VALUES 
                    (@BestellNr, @Farbe1, @Farbe2, @Farbe1Menge, @Farbe2Menge);
                ";

                // Parameter befüllen
                SQLiteParameter[] parameters = new SQLiteParameter[5];
                parameters[0] = new SQLiteParameter("@BestellNr", BestellNr);
                parameters[1] = new SQLiteParameter("@Farbe1", ArtikelBasket.Count > 0 ? ArtikelBasket[0].Farbe : (object)DBNull.Value);
                parameters[2] = new SQLiteParameter("@Farbe2", ArtikelBasket.Count > 1 ? ArtikelBasket[1].Farbe : (object)DBNull.Value);
                parameters[3] = new SQLiteParameter("@Farbe1Menge", ArtikelBasket.Count > 0 ? ArtikelBasket[0].Menge : (object)DBNull.Value);
                parameters[4] = new SQLiteParameter("@Farbe2Menge", ArtikelBasket.Count > 1 ? ArtikelBasket[1].Menge : (object)DBNull.Value);

                // Ausführen
                cm.ExecuteNonQuery(query, parameters);


                Abgeschlossen = true;
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception($"Fehler beim Speichern der Bestellung: {ex.Message}");
            }
        }

        public bool SaveToLagerAndDeleteBestellung()
        {
            var cm = ConnectionManager.GetInstance();

            try
            {
                // 1. Bestellartikel ins Lager einfügen oder Lagerbestand aktualisieren
                foreach (var artikel in ArtikelBasket)
                {
                    string lagerQuery = @"
                                UPDATE Lager 
                                SET Menge = Menge + @Menge
                                WHERE Farbe = @Farbe;
                            ";

                    // Parameter für die Lageraktualisierung
                    SQLiteParameter[] lagerParameters = new SQLiteParameter[2];
                    lagerParameters[0] = new SQLiteParameter("@Farbe", artikel.Farbe);
                    lagerParameters[1] = new SQLiteParameter("@Menge", artikel.Menge);

                    int rowsAffected = cm.ExecuteNonQuery(lagerQuery, lagerParameters);

                    // Wenn kein Artikel gefunden wurde, füge ihn in das Lager ein
                    if (rowsAffected == 0)
                    {
                    string insertLagerQuery = @"
                        INSERT INTO Lager (Farbe, Menge) 
                        VALUES (@Farbe, @Menge);";

                        cm.ExecuteNonQuery(insertLagerQuery, lagerParameters);
                    }
                }

                // 2. Bestellung in das Archiv übertragen (ohne BestellNr, da sie auto-incrementiert wird)
                string insertArchivQuery = @"
                    INSERT INTO Bestellungen_Archiv (Farbe_1, Farbe_2, Farbe_1_menge, Farbe_2_menge) 
                    SELECT Farbe_1, Farbe_2, Farbe_1_menge, Farbe_2_menge 
                    FROM Bestellungen 
                    WHERE BestellNr = @BestellNr;";

                SQLiteParameter[] archivParameters = new SQLiteParameter[1];
                archivParameters[0] = new SQLiteParameter("@BestellNr", BestellNr);

                cm.ExecuteNonQuery(insertArchivQuery, archivParameters);

                // 3. Bestellung löschen
                string deleteQuery = @"
                DELETE FROM Bestellungen 
                WHERE BestellNr = @BestellNr;";

                SQLiteParameter[] deleteParameters = new SQLiteParameter[1];
                deleteParameters[0] = new SQLiteParameter("@BestellNr", BestellNr);

                cm.ExecuteNonQuery(deleteQuery, deleteParameters);

                // Bestellung als abgeschlossen markieren
                Abgeschlossen = true;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Fehler beim Übertragen der Bestellung ins Lager und Archiv: {ex.Message}");
            }
        }



        public static _Bestellung GetBestellungByBestellNr(int bestellNr)
        {
            var cm = ConnectionManager.GetInstance();

            try
            {
                // SQL-Abfrage zum Abrufen der Bestellung basierend auf der BestellNr
                string query = @"
            SELECT BestellNr, Farbe_1, Farbe_2, Farbe_1_menge, Farbe_2_menge 
            FROM Bestellungen 
            WHERE BestellNr = @BestellNr;
        ";

                // Parameter befüllen
                SQLiteParameter[] parameters = new SQLiteParameter[1];
                parameters[0] = new SQLiteParameter("@BestellNr", bestellNr);

                // Die Abfrage ausführen
                var dt = cm.ExecuteQuery(query, parameters);

                // Wenn keine Zeilen zurückgegeben wurden, BestellNr existiert nicht
                if (dt.Rows.Count == 0)
                {
                    return null;  // Bestellung nicht gefunden
                }

                // Eine Bestellung aus der ersten Zeile der Ergebnistabelle erstellen
                var row = dt.Rows[0];
                var bestellung = new _Bestellung
                {
                    BestellNr = Convert.ToInt32(row["BestellNr"]),
                };

                // Artikel zur Bestellung hinzufügen (bis zu 2)
                if (row["Farbe_1"] != DBNull.Value)
                {
                    bestellung.AddArtikel("Artikel1", row["Farbe_1"].ToString(), Convert.ToInt32(row["Farbe_1_menge"]));
                }
                if (row["Farbe_2"] != DBNull.Value)
                {
                    bestellung.AddArtikel("Artikel2", row["Farbe_2"].ToString(), Convert.ToInt32(row["Farbe_2_menge"]));
                }

                return bestellung;
            }
            catch (Exception ex)
            {
                throw new Exception($"Fehler beim Abrufen der Bestellung: {ex.Message}");
            }
        }




    }




    internal class Artikel
    {
        public string Name { get; set; }
        public string Farbe { get; set; }
        public int Menge { get; set; }

        public Artikel(string name, string farbe, int menge)
        {
            Name = name;
            Farbe = farbe;
            Menge = menge;
        }

        public override string ToString()
        {
            return $"{Name} ({Farbe}, {Menge})";
        }
    }
}
