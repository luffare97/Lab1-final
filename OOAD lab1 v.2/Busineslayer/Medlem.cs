using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Busineslayer
{
    public class Medlem
    {

        internal int MedlemsNr { get; set; }
        internal string Namn { get; set; }
        private int TeleNr { get; set; }
        private string EMail { get; set; }
        internal List<Bokning> Bokningar { get; set; }


        internal Medlem(int NR, string namn, int teleNr, string mail)
        {
            this.MedlemsNr = NR;
            this.Namn = namn;
            this.TeleNr = teleNr;
            this.EMail = mail;
            this.Bokningar = new List<Bokning>();
        }

    }
}
