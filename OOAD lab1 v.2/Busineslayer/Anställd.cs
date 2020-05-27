using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer
{
    public class Anställd
    {
        internal int AnstNr { get; set; }
        private string Namn { get; set; }
        private string Roll { get; set; }
        internal List<Bokning> Bokningar { get; set; }
        private string Lösenord { get; set; }

        internal Anställd(int NR, string namn, string lösen, string roll)
        {
            this.AnstNr = NR;
            this.Namn = namn;
            this.Lösenord = lösen;
            this.Roll = roll;
            this.Bokningar = new List<Bokning>();
        }

        public override string ToString()
        {
            return AnstNr + " " + Namn;
        }


        //Metod för att logga in
        public bool LoggaIn(string lösen)
        {
            bool OK = false;
            if (Lösenord == lösen)
            {
                OK = true;
            }
            return OK;
        }
    }
}
