using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer
{
    public class Faktura
    {

        internal int FakturaId { get; set; }
        internal int Pris { get; set; }
        private Bokning Bokning { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }

        internal Faktura(Bokning bokning)
        {

            this.Bokning = bokning;
            foreach (Bok b in bokning.Böcker)
            {
                b.Bokning = null;
            }

            this.StartDate = bokning.StartDate;
            this.EndDate = DateTime.Today;


            //Räknar ut priset
            TimeSpan ts = EndDate - bokning.EndDate;
            int Antal = 0;
            foreach (Bok b in bokning.Böcker)
            {
                Antal++;
            }

            this.Pris = (Antal * ts.Days) * 10;
            

        }
    }
}
