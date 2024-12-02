using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tischprojekt.Data.obj.dataObj
{
    public static class SQLquerys
    {
        public static String getAllFarben = "SELECT * FROM Farben";
        public static String getAllMengen = "SELECT * FROM Mengen";
        public static String getAllFormen = "SELECT * FROM Formen";

        public static String deleteAllFarben = "DELETE FROM FARBEN";
        public static String deleteAllMengen = "DELETE FROM Mengen";
        public static String deleteAllFormen = "DELETE FROM Formen";

        public static String insertIntoFarben = "INSERT INTO Farben (Farbe_1) VALUES (@FARBE)";
        public static String insertIntoMengen = "INSERT INTO Mengen (Menge_1) VALUES (@MENGEN)";
        public static String insertIntoFormen = "INSERT INTO Formen (Form_1) VALUES (@FORMEN)";


        public static String InsertIntoAcceptedOrders = "INSERT INTO AcceptedOrders (Nr, DatumBeginn, DatumAbgabe, Form, Farbe, IstRetoure) VALUES (@Nr, @DatumBeginn, @DatumAbgabe, @Form, @Farbe, @IstRetoure)";
        public static String getAllAcceptedOrders = "SELECT * FROM AcceptedOrders";
    }
}
