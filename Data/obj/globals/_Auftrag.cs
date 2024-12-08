using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Tischprojekt.Data;
using Tischprojekt.Data.obj.dataObj;
using Tischprojekt.Data.obj.Userctrl;

namespace Tischprojekt.Data.obj
{
    public  class _Auftrag
    {

        public int Nr{get; set;} 
        public DateTime Beginn {get; set;} 
        public DateTime Abgabe{ get; set;} 
        public int Menge{get; set;} 
        public string Form{ get; set;} 
        public string Farbe{ get; set;} 


        public bool Abgeschlossen{get; set;} 
        public bool Abgelehnt{get; set;} 
        public bool Angenommen{get; set;} 
        public int Strafzeit{get; set;}

        
        public bool IstRetoure
        {
            get; set;
        } 

        
        public _Auftrag(int nr, DateTime beginn, DateTime abgabe, int menge, string form, string farbe)
        {
            Nr = nr;
            Beginn = beginn;
            Abgabe = abgabe;
            Menge = menge;
            Form = form;
            Farbe = farbe;
            Abgeschlossen = false;
            Abgelehnt = false;
            Angenommen = false;
            Strafzeit = 0;
            IstRetoure = false;
        }

        public static _Auftrag GetAuftragByNr(int nr, bool Active)
        {
            var connectionManager = ConnectionManager.GetInstance();

            var parameter = new SQLiteParameter("@Nr", nr);

            try
            {
                DataTable result = new DataTable();
                if (Active)
                {
                    result = connectionManager.ExecuteQuery(SQLquerys.getActiveOrderByNr, parameter);

                }
                else
                {
                   result = connectionManager.ExecuteQuery(SQLquerys.getOrderByOrderNr, parameter);

                }
                

                if (result.Rows.Count == 0)
                {
                    Console.WriteLine($"Kein Auftrag mit der Nummer {nr} gefunden.");
                    return null;
                }

                DataRow row = result.Rows[0];
                DateTime beginn;
                bool istRetoure;
                    DateTime abgabe;
                int nummer = Convert.ToInt32(row["Nr"]);
                if (Active) {

                    beginn = DateTime.Parse(row["DatumBeginn"].ToString());
                    abgabe = DateTime.Parse(row["DatumEnde"].ToString());
                    istRetoure = Convert.ToBoolean(row["IstRetoure"]);
                }
                else
                {
                    beginn = DateTime.Parse(row["AuftragsAnfang"].ToString());
                    abgabe = DateTime.Parse(row["AuftragsEnde"].ToString());
                    istRetoure = Convert.ToBoolean(row["Retoure"]);

                }
                int menge = Convert.ToInt32(row["Menge"]);
                string form = row["Form"].ToString();
                string farbe = row["Farbe"].ToString();


                var auftrag = new _Auftrag(nummer, beginn, abgabe, menge, form, farbe)
                {
                    IstRetoure = istRetoure
                };
                return auftrag;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Abrufen des Auftrags: {ex.Message}");
                return null;
            }
        }



        public void AuftragAbschließen()
        {
            Abgeschlossen = true;
            Console.WriteLine($"Auftrag Nr. {Nr} wurde abgeschlossen.");

            var connectionManager = ConnectionManager.GetInstance();

            // SQL-Update-Abfrage, um den Auftrag als abgeschlossen zu markieren
            string updateOrdersQuery = @"
        UPDATE Orders 
        SET Abgeschlossen = @Abgeschlossen,
            AuftragsEndeIST = @AktuelleZeit,
            AuftragsEndeNeu = CASE WHEN Retoure = 1 THEN @AktuelleZeit ELSE AuftragsEndeNeu END
        WHERE Nr = @Nr;";

            string deleteFromActiveOrdersQuery = "DELETE FROM ActiveOrders WHERE Nr = @Nr";

            // SQL-Befehl zum Einfügen von Daten in Retoure_Archiv
            string insertIntoRetoureArchivQuery = @"
        INSERT INTO Retoure_Archiv (OrderNr, Menge, Form, AuftrasAnfangOrg, AuftrasEndeOrg, Strafsekunden, Bemerkung, AuftragsAnfangNeu, AuftragsEndeNeu, ZusatzMenge, Abgeschlossen)
        SELECT OrderNr, Menge, Form, AuftragsAnfangOrg, AuftragsEndeOrg, Strafsekunden, Bemerkung, AuftragsAnfangNeu, AuftragsEndeNeu, ZusatzMenge, @Abgeschlossen
        FROM Retoure
        WHERE OrderNr = @Nr;";

            string deleteFromRetoureQuery = "DELETE FROM Retoure WHERE OrderNr = @Nr";

            var parameters = new[]
            {
        new SQLiteParameter("@Abgeschlossen", Abgeschlossen ? 1 : 0),
        new SQLiteParameter("@Nr", Nr),
        new SQLiteParameter("@AktuelleZeit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
    };

            try
            {
                // Überprüfen, ob es eine Retoure für diesen Auftrag gibt
                var retoureExistsQuery = "SELECT COUNT(*) FROM Retoure WHERE OrderNr = @Nr;";
                var retoureExists = connectionManager.ExecuteScalar(retoureExistsQuery, new SQLiteParameter("@Nr", Nr));

                if (retoureExists != null && Convert.ToInt32(retoureExists) > 0)
                {
                    Console.WriteLine($"Retoure gefunden für Auftrag Nr. {Nr}. Daten in Retoure_Archiv verschieben.");

                    // Daten in Retoure_Archiv speichern
                    int rowsInserted = connectionManager.ExecuteNonQuery(insertIntoRetoureArchivQuery, parameters);

                    if (rowsInserted > 0)
                    {
                        Console.WriteLine($"Daten erfolgreich in Retoure_Archiv gespeichert.");
                    }
                    else
                    {
                        Console.WriteLine($"Fehler beim Speichern in Retoure_Archiv.");
                    }

                    // Daten aus Retoure löschen
                    int rowsDeletedRetoure = connectionManager.ExecuteNonQuery(deleteFromRetoureQuery, new SQLiteParameter("@Nr", Nr));

                    if (rowsDeletedRetoure > 0)
                    {
                        Console.WriteLine($"Daten erfolgreich aus Retoure gelöscht.");
                    }
                    else
                    {
                        Console.WriteLine($"Fehler beim Löschen aus Retoure.");
                    }
                }

                // Den Auftrag als abgeschlossen markieren und aus ActiveOrders löschen
                int rowsUpdated = connectionManager.ExecuteNonQuery(updateOrdersQuery, parameters);

                if (rowsUpdated > 0)
                {
                    Console.WriteLine($"Auftrag Nr. {Nr} erfolgreich in Orders aktualisiert.");

                    int rowsDeletedFromActiveOrders = connectionManager.ExecuteNonQuery(deleteFromActiveOrdersQuery, new SQLiteParameter("@Nr", Nr));
                    if (rowsDeletedFromActiveOrders > 0)
                    {
                        Console.WriteLine($"Auftrag Nr. {Nr} erfolgreich aus ActiveOrders gelöscht.");
                    }
                    else
                    {
                        Console.WriteLine($"Fehler beim Löschen aus ActiveOrders.");
                    }
                }
                else
                {
                    Console.WriteLine($"Fehler beim Aktualisieren in Orders.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Abschluss des Auftrags: {ex.Message}");
            }
        }





        public void AuftragAblehnen()
        {
            Abgelehnt = true;
            Abgeschlossen = false;
            Angenommen = false;
            Console.WriteLine($"Auftrag Nr. {Nr} wurde abgelehnt.");
        }

        
        public void AuftragAnnehmen()
        {
            if (!Abgelehnt)
            {
                Angenommen = true;
                Console.WriteLine($"Auftrag Nr. {Nr} wurde angenommen.");
            }
            else
            {
                Console.WriteLine($"Auftrag Nr. {Nr} wurde bereits abgelehnt und kann nicht angenommen werden.");
            }
        }


        public bool AuftragSetRetoure(int strafsekunden, int Zusatzmaterial,String Bemerkung)
        {
            if (Abgeschlossen)
            {


                Console.WriteLine($"Auftrag Nr. {Nr} wird als Retoure eingetragen.");

                var connectionManager = ConnectionManager.GetInstance();

                // Prüfen, ob Zusatzmaterial > 0 ist und genug Bestand im Lager vorhanden ist
                if (Zusatzmaterial > 0)
                {
                    try
                    {
                        // Überprüfen, ob genug Bestand vorhanden ist
                        string checkStockQuery = "SELECT Menge FROM Lager WHERE Farbe = @Farbe;";
                        var stockParameter = new[] { new SQLiteParameter("@Farbe", Farbe) };
                        var currentStock = Convert.ToInt32(connectionManager.ExecuteScalar(checkStockQuery, stockParameter));

                        if (currentStock < Zusatzmaterial)
                        {
                            MessageBox.Show($"Nicht genug Bestand im Lager für {Zusatzmaterial} Einheiten von {Farbe}. Aktueller Bestand: {currentStock}",
                                            "Lagerbestand zu niedrig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        // Bestand aus dem Lager ausbuchen
                        string updateStockQuery = "UPDATE Lager SET Menge = Menge - @Zusatzmaterial WHERE Farbe = @Farbe;";
                        var updateStockParameters = new[]
                        {
                    new SQLiteParameter("@Zusatzmaterial", Zusatzmaterial),
                    new SQLiteParameter("@Farbe", Farbe)
                };
                        int rowsAffected = connectionManager.ExecuteNonQuery(updateStockQuery, updateStockParameters);

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Zusatzmaterial: {Zusatzmaterial} Einheiten von {Farbe} wurden aus dem Lager ausgebucht.");
                        }
                        else
                        {
                            Console.WriteLine("Fehler beim Ausbuchen des Zusatzmaterials aus dem Lager.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Fehler beim Prüfen oder Ausbuchen aus dem Lager: {ex.Message}");
                    }
                }
                IstRetoure = true;
                Abgeschlossen = false;
                // Update Orders - Setze Retoure, Abgeschlossen und Strafsekunden
                string updateOrdersQuery = @"
            UPDATE Orders 
            SET Retoure = 1, 
                Abgeschlossen = 0, 
                AuftragsAnfangNeu = @AktuelleZeit,
                Strafsekunden = @Strafsekunden 
            WHERE Nr = @Nr;";

                var updateOrdersParameters = new[]
                {
            new SQLiteParameter("@Nr", Nr),
            new SQLiteParameter("@AktuelleZeit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
            new SQLiteParameter("@Strafsekunden", strafsekunden)
        };

                try
                {
                    int rowsUpdated = connectionManager.ExecuteNonQuery(updateOrdersQuery, updateOrdersParameters);

                    if (rowsUpdated > 0)
                    {
                        Console.WriteLine($"Auftrag Nr. {Nr} wurde in der Tabelle Orders als Retoure markiert und Strafsekunden eingetragen.");

                        // Insert into Retoure-Tabelle
                        var insertIntoRetoureParameters = new[]
                        {
                    new SQLiteParameter("@OrderNr", Nr),
                    new SQLiteParameter("@Menge", Menge),
                    new SQLiteParameter("@Farbe", Farbe),
                    new SQLiteParameter("@Form", Form),
                    new SQLiteParameter("@AuftragsAnfangOrg", Beginn.ToString("yyyy-MM-dd HH:mm:ss")),
                    new SQLiteParameter("@AuftragsEndeOrg", Abgabe.ToString("yyyy-MM-dd HH:mm:ss")),
                    new SQLiteParameter("@Strafsekunden", strafsekunden),
                    new SQLiteParameter("@Bemerkung", Bemerkung),
                    new SQLiteParameter("@ZusatzMenge", Zusatzmaterial)
                };

                        int rowsInsertedIntoRetoure = connectionManager.ExecuteNonQuery(SQLquerys.insertIntoRetoure, insertIntoRetoureParameters);

                        if (rowsInsertedIntoRetoure > 0)
                        {
                            Console.WriteLine($"Auftrag Nr. {Nr} wurde erfolgreich in die Tabelle Retoure eingetragen.");

                            // Insert into ActiveOrders-Tabelle
                            string insertIntoActiveOrdersQuery = @"
                        INSERT INTO ActiveOrders (Nr, DatumBeginn, DatumEnde, Form, Farbe, IstRetoure, Menge) 
                        VALUES (@Nr, @DatumBeginn, @DatumEnde, @Form, @Farbe, @IstRetoure, @Menge);";

                            var insertIntoActiveOrdersParameters = new[]
                            {
                        new SQLiteParameter("@Nr", Nr),
                        new SQLiteParameter("@DatumBeginn", Beginn.ToString("yyyy-MM-dd HH:mm:ss")),
                        new SQLiteParameter("@DatumEnde", Abgabe.ToString("yyyy-MM-dd HH:mm:ss")),
                        new SQLiteParameter("@Form", Form),
                        new SQLiteParameter("@Farbe", Farbe),
                        new SQLiteParameter("@IstRetoure", 1),
                        new SQLiteParameter("@Menge", Menge + Zusatzmaterial),
                    };

                            int rowsInsertedIntoActiveOrders = connectionManager.ExecuteNonQuery(insertIntoActiveOrdersQuery, insertIntoActiveOrdersParameters);

                            if (rowsInsertedIntoActiveOrders > 0)
                            {
                                Console.WriteLine($"Auftrag Nr. {Nr} wurde erfolgreich in die Tabelle ActiveOrders eingetragen.");
                                Dashboard.GetInstance().UpdateDGVs();
                                return true;
                            }
                            else
                            {
                                Console.WriteLine($"Fehler: Auftrag Nr. {Nr} konnte nicht in ActiveOrders eingetragen werden.");
                                return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Fehler: Auftrag Nr. {Nr} konnte nicht in Retoure eingetragen werden.");
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Fehler: Auftrag Nr. {Nr} konnte nicht in Orders aktualisiert werden.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Verarbeiten der Retoure für Auftrag Nr. {Nr}: {ex.Message}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Auftrag Nr. {Nr} ist nicht abgeschlossen und kann nicht als Retoure eingetragen werden.");
                return false;
            }
        }






    }
}
