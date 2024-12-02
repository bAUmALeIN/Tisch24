using System;

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

       
        public void AuftragAbschließen()
        {
            if (!Abgelehnt && Angenommen)
            {
                Abgeschlossen = true;
                Console.WriteLine($"Auftrag Nr. {Nr} wurde abgeschlossen.");
            }
            else
            {
                Console.WriteLine($"Auftrag Nr. {Nr} kann nicht abgeschlossen werden. Überprüfe den Status.");
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
