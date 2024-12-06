using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Tischprojekt.Data.obj.dataObj
{
    public static class SQLquerys
    {


        // DELETE
        public static String deleteALLFromLager = "DELETE FROM Lager";
        public static String deleteALLFromActiveOrders = "DELETE FROM ActiveOrders";
        public static String deleteALLFromAcceptedOrders = "DELETE FROM AcceptedOrders";
        public static String deleteALLFromActveDeliverys = "DELETE FROM Bestellungen";
        public static String deleteALLFromOrders = "DELETE FROM Orders";
        public static String deleteAllFarben = "DELETE FROM FARBEN";
        public static String deleteAllMengen = "DELETE FROM Mengen";
        public static String deleteAllFormen = "DELETE FROM Formen";
        public static String deleteFromActiveOrders = "DELETE FROM ActiveOrders WHERE Nr = @Nr";
        public static String deleteFromAcceptedOrders = "DELETE FROM AcceptedOrders WHERE Nr = @Nr";
        public static String deleteFromLagerWhereMenge0 = "DELETE FROM Lager WHERE Menge = 0";

        public static String getAllFarben = "SELECT * FROM Farben";
        public static String getAllMengen = "SELECT * FROM Mengen";
        public static String getAllFormen = "SELECT * FROM Formen";


        //INSERT - EINSTELLUNGEN
        public static String insertIntoFarben = "INSERT INTO Farben (Farbe_1) VALUES (@FARBE)";
        public static String insertIntoMengen = "INSERT INTO Mengen (Menge_1) VALUES (@MENGEN)";
        public static String insertIntoFormen = "INSERT INTO Formen (Form_1) VALUES (@FORMEN)";

        //INSERT  AUFTRÄGE
        public static String insertIntoOrders = "INSERT INTO Orders (Nr,Menge,Farbe,Form,AuftragsAnfang,AuftragsEnde,Strafsekunden,Angenommen,Abgelehnt,Abgeschlossen,Retoure) VALUES (@Nr, @Menge,@Farbe, @Form, @AuftragsAnfang, @AuftragsEnde,@Strafsekunden,@Angenommen,@Abgelehnt,@Abgeschlossen,@Retoure)";
        public static String InsertIntoAcceptedOrders = "INSERT INTO AcceptedOrders (Nr, DatumBeginn, DatumAbgabe, Form, Farbe, IstRetoure,Menge) VALUES (@Nr, @DatumBeginn, @DatumAbgabe, @Form, @Farbe, @IstRetoure,@Menge)";
        public static String insertIntoActiveOrders = "INSERT INTO ActiveOrders (Nr, DatumBeginn, DatumEnde, Form, Farbe, IstRetoure,Menge) VALUES (@Nr, @DatumBeginn, @DatumAbgabe, @Form, @Farbe, @IstRetoure,@Menge)";
        public static String insertIntoLager = "INSERT INTO Lager (Farbe,Menge) VALUES (@Farbe,@Menge) ON CONFLICT(Farbe) DO UPDATE SET Menge = Menge + excluded.Menge;";

        public static String getAllAcceptedOrders = "SELECT * FROM AcceptedOrders";
        public static String getAllLagerPOS = "SELECT * FROM Lager";
        public static String getAllAktiveOrdersPOS = "SELECT * FROM ActiveOrders";
        public static String getAllAktiveBestellungenPOS = "SELECT * FROM Bestellungen";


        /// <summary>
        /// LAGER
        /// </summary>
        public static String SelectLagerMengeWhereNrAndFarbe = "SELECT Menge FROM Lager WHERE Farbe = @Farbe AND Menge >= @Menge";
        public static String UpdateLagerbestand = "UPDATE Lager SET Menge = Menge - @Menge WHERE Farbe = @Farbe";
        public static String SelectMengeFromLager = "SELECT Menge FROM Lager WHERE Farbe = @Farbe";
        public static String SortLagerPOS = "UPDATE Lager SET POS = (SELECT ROW_NUMBER() OVER (ORDER BY POS));";

        /// <summary>
        /// Bestellen
        /// </summary>
        public static String inertIntoBestellungen = "INSERT INTO Bestellungen (BestellNr,Farbe_1,Farbe_2,Farbe_1_menge,Farbe_2_menge) VALUES (@BestellNr,@Farbe1,@Farbe2,@Farbe1menge,@Farbe2menge)";
        public static String nextFreeNumberFromBestellungen = "SELECT COALESCE(MAX(BestellNr), 0) + 1 AS NextFreeNr FROM Bestellungen";
    }
}
