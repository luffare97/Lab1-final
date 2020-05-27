using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer
{

    
    internal class DataStore
    {

        //Datastore klassen kommer att agera som våra repositorys då vi sparar alla listor här i för enkelhetens skull
        private List<Anställd> Anställda { get; set; } = new List<Anställd>();
        private List<Bokning> Bokningar { get; set; } = new List<Bokning>();
        private List<Bok> Böcker { get; set; } = new List<Bok>();
        private List<Faktura> Fakturor { get; set; } = new List<Faktura>();
        private List<Medlem> Medlemmar { get; set; } = new List<Medlem>();

        internal DataStore()
        {
            LaddaInData();
        }

        private void LaddaInData() //Laddar in alla data i systemet
        {

            //Skapar en bok för initiciell bokning
            Bok B = new Bok(1234, "sagan om ringen");
            Böcker.Add(B);

            //Ladda in böcker
            Böcker.Add(new Bok(1235, "Bibeln"));
            Böcker.Add(new Bok(1236, "Harry Potter"));
            Böcker.Add(new Bok(1237, "Hur du tränar din drake"));
            Böcker.Add(new Bok(1238, "The shining"));
            Böcker.Add(new Bok(1239, "How to get dates"));
            Böcker.Add(new Bok(1240, "How to get rich"));
            Böcker.Add(new Bok(1241, "How to get poor"));
            Böcker.Add(new Bok(1242, "Drugs are good for you"));
            Böcker.Add(new Bok(1243, "C# for dummies"));
            Böcker.Add(new Bok(1244, "Repositories for dummies"));

            //Skapar en anställd för initiciell bokning
            Anställd A = new Anställd(1, "Janne", "LOL", "chef");
            Anställda.Add(A);

            //Ladda in anställda
            Anställda.Add(new Anställd(2, "Amy", "LOL", "expedit"));
            Anställda.Add(new Anställd(3, "Björn", "LOL", "expedit"));
            Anställda.Add(new Anställd(4, "Lars", "LOL", "expedit"));
            Anställda.Add(new Anställd(5, "Matilda", "LOL", "expedit"));
            Anställda.Add(new Anställd(6, "Jöran", "LOL", "expedit"));
            Anställda.Add(new Anställd(7, "Peter", "LOL", "expedit"));
            Anställda.Add(new Anställd(8, "Sofia", "LOL", "expedit"));
            Anställda.Add(new Anställd(9, "Bigdick", "LOL", "chef"));

            //Skapar en medlem för initiciell bokning
            Medlem M = new Medlem(1, "Daniel", 070987654, "Daniel@hotmail.com");
            Medlemmar.Add(M);

            //Ladda in medlemmar
            Medlemmar.Add(new Medlem(2, "Erik", 070987123, "Erikl@hotmail.com"));
            Medlemmar.Add(new Medlem(3, "Louise", 070987345, "Louise@hotmail.com"));
            Medlemmar.Add(new Medlem(4, "Axel", 0709875667, "Axel@hotmail.com"));
            Medlemmar.Add(new Medlem(5, "Mohamed", 070987789, "Mohamed@hotmail.com"));
            Medlemmar.Add(new Medlem(6, "El-heffe", 07091234, "ElHeffe@hotmail.com"));
            Medlemmar.Add(new Medlem(7, "Hampus", 070984567, "Hampus@hotmail.com"));
            Medlemmar.Add(new Medlem(8, "Pochahontas", 070985678, "Pochahontas@hotmail.com"));
            Medlemmar.Add(new Medlem(9, "Ariel", 070912345, "Ariel@hotmail.com"));


            //Ladda in en försenad bokning

            //Skapar en boklista
            List<Bok> BokningBöcker = new List<Bok>();
            BokningBöcker.Add(B);

            //Skapar bokningen
            Bokning bokning = new Bokning(M, A, BokningBöcker, new DateTime(2020, 02, 10), new DateTime(2020, 03, 10));
            bokning.BokningsNr = 1;

            Bokningar.Add(bokning);

            

        }

        internal Anställd LoggaIn(int NR, string lösen) //Loggar in i systemet
        {
            Anställd inloggad = null;

            foreach (Anställd A in Anställda)
            {
                if (A.AnstNr == NR)
                {
                    if (A.LoggaIn(lösen) == true)
                    {
                        inloggad = A;
                    }
                }
            }
            return inloggad;
        }

        internal List<Bok> GetTillgängligaBöcker() //Hämta tillgängliga böcker
        {
            List<Bok> TillgängligaBöcker = new List<Bok>();

            foreach (Bok b in Böcker)
            {
                if (b.Bokning == null)
                {
                    TillgängligaBöcker.Add(b);
                }
            }
            return TillgängligaBöcker;
        }

        internal List<Bok> GetUpptagnaBöcker() //Hämta Upptagna böcker
        {
            List<Bok> UpptagnaBöcker = new List<Bok>();

            foreach (Bok b in Böcker)
            {
                if (b.Bokning != null)
                {
                    UpptagnaBöcker.Add(b);
                }
            }
            return UpptagnaBöcker;
        }

        internal Medlem GetMedlem(int ID) //Hämtar en specifik medlem 
        {
            Medlem M = null;

            foreach (Medlem m in Medlemmar)
            {
                if (m.MedlemsNr == ID)
                {
                    M = m;
                    break;
                }
            }

            return M;
        }

        internal int SkapaBokning(int mid, Anställd ans, List<Bok> böcker) //Skapar en bokning utifrån de valda böckerna och gör dem otillgängliga
        {
            Medlem M = GetMedlem(mid);

            Bokning B = new Bokning(M, ans, böcker);
           
            B.BokningsNr = Bokningar.Count + 1;

            Bokningar.Add(B);

            return B.BokningsNr;
        }

        internal Bokning GetBokning(int ID) //Hämtar en specifik bokning
        {
            Bokning b = null;

            foreach (Bokning bokning in Bokningar)
            {
                if (bokning.BokningsNr == ID )
                {
                    b = bokning;
                    break;
                }
            }
            return b;
        }

        internal DateTime GetBokningTime(int ID)
        {
            Bokning b = GetBokning(ID);
            return b.StartDate;
        }

        internal List<Bokning> GetBokningar() //Hämtar alla bokningar
        {
            return Bokningar;
        }

        internal int SkapaFaktura(Bokning bokning) //Skapar en faktura
        {
            Faktura faktura = new Faktura(bokning);

            faktura.FakturaId = Fakturor.Count + 1;

            return faktura.Pris;
        }

        internal int AvslutaBokning(int ID) //Avslutar en bokning
        {
            Bokning bokning = GetBokning(ID);
            bokning.Aktiv = false;

            return SkapaFaktura(bokning);
        }

    }
}
