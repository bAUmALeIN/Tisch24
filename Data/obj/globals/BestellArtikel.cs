using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tischprojekt.Data.obj.globals
{
    internal class BestellArtikel
    {
        internal class Artikel
        {
            public string ArtikelName { get; set; } 
            public string Farbe { get; set; }       
            public int Menge { get; set; }          

            public Artikel(string artikelName, string farbe, int menge)
            {
                ArtikelName = artikelName;
                Farbe = farbe;
                Menge = menge;
            }

            public override string ToString()
            {
                return $"{ArtikelName} - Farbe: {Farbe}, Menge: {Menge}";
            }
        }

    }
}
