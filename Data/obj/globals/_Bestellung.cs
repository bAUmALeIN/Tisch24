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
                cm.BeginTransaction();

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

                cm.CommitTransaction();
                Abgeschlossen = true;
                return true;
            }
            catch (Exception ex)
            {
                cm.RollbackTransaction();
                throw new Exception($"Fehler beim Speichern der Bestellung: {ex.Message}");
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
