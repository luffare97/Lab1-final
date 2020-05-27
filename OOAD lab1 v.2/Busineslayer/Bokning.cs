using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer
{
    public class Bokning
    {

        private Medlem Medlem { get; set; }
        private Anställd Anställd { get; set; }
        internal int BokningsNr { get; set; }
        internal DateTime StartDate { get; set; }
        internal DateTime EndDate { get; set; }
        internal List<Bok> Böcker { get; set; }
        public bool Aktiv { get; set; }


        internal Bokning(Medlem med, Anställd ans, List<Bok> böcker)
        {
            this.Medlem = med;
            this.Anställd = ans;
            this.Böcker = böcker;

            foreach (Bok b in Böcker)
            {
                b.Bokning = this;
            }

            this.Aktiv = true;

            this.StartDate = DateTime.Today;
            this.EndDate = StartDate.AddDays(7);

        }

        internal Bokning(Medlem med, Anställd ans, List<Bok> böcker, DateTime start, DateTime slut)
        {
            this.Medlem = med;
            Medlem.Bokningar.Add(this);

            this.Anställd = ans;
            Anställd.Bokningar.Add(this);

            this.Böcker = böcker;

            foreach (Bok b in Böcker)
            {
                b.Bokning = this;
            }

            this.Aktiv = true;

            this.StartDate = start;
            this.EndDate = slut;

        }

        public override string ToString()
        {
            return BokningsNr + " " + Medlem.Namn;
        }
    }
}
