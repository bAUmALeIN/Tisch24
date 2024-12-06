using System;
using System.Data;
using System.Data.SQLite;
using Tischprojekt.Data;
using Tischprojekt.Data.obj.dataObj;

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

        public static _Auftrag GetAuftragByNr(int nr)
        {
            var connectionManager = ConnectionManager.GetInstance();

            var parameter = new SQLiteParameter("@Nr", nr);

            try
            {
                DataTable result = connectionManager.ExecuteQuery(SQLquerys.getActiveOrderByNr, parameter);

                if (result.Rows.Count == 0)
                {
                    Console.WriteLine($"Kein Auftrag mit der Nummer {nr} gefunden.");
                    return null;
                }

                DataRow row = result.Rows[0];

                int nummer = Convert.ToInt32(row["Nr"]);
                DateTime beginn = DateTime.Parse(row["DatumBeginn"].ToString());
                DateTime abgabe = DateTime.Parse(row["DatumEnde"].ToString());
                int menge = Convert.ToInt32(row["Menge"]);
                string form = row["Form"].ToString();
                string farbe = row["Farbe"].ToString();
                bool istRetoure = Convert.ToBoolean(row["IstRetoure"]);

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

                // Datenbank aktualisieren
                var connectionManager = ConnectionManager.GetInstance();

                // SQL-Update-Abfrage, um den Auftrag als abgeschlossen zu markieren
                string updateQuery = "UPDATE Orders SET Abgeschlossen = @Abgeschlossen WHERE Nr = @Nr";
                string deleteQuery = "DELETE FROM ActiveOrders WHERE Nr = @Nr";

                var parameters = new[]
                {
                    new SQLiteParameter("@Abgeschlossen", Abgeschlossen ? 1 : 0),
                    new SQLiteParameter("@Nr", Nr)
                };

                try
                {
                    int rowsUpdated = connectionManager.ExecuteNonQuery(updateQuery, parameters);
                    if (rowsUpdated > 0)
                    {
                        Console.WriteLine($"Auftrag Nr. {Nr} erfolgreich in Orders aktualisiert.");

                        // Auftrag aus ActiveOrders löschen
                        int rowsDeleted = connectionManager.ExecuteNonQuery(deleteQuery, new SQLiteParameter("@Nr", Nr));
                        if (rowsDeleted > 0)
                        {
                            Console.WriteLine($"Auftrag Nr. {Nr} erfolgreich aus ActiveOrders gelöscht.");
                        }
                        else
                        {
                            Console.WriteLine($"Fehler: Auftrag Nr. {Nr} konnte nicht aus ActiveOrders gelöscht werden.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Fehler: Auftrag Nr. {Nr} konnte nicht in Orders aktualisiert werden.");
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

       
        public void AuftragZurücksetzen()
        {
            if (Abgeschlossen)
            {
                IstRetoure = true;
                Abgeschlossen = false;
                Console.WriteLine($"Auftrag Nr. {Nr} wurde zurückgesetzt (Retoure).");
            }
            else
            {
                Console.WriteLine($"Auftrag Nr. {Nr} ist nicht abgeschlossen und kann nicht zurückgesetzt werden.");
            }
        }
    }
}
