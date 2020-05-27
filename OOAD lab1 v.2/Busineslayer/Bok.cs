using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer
{
    public class Bok
    {
        internal Bokning Bokning { get; set; }
        private int ISBNnr { get; set; }
        private string Titel { get; set; }


        internal Bok(int isbn, string titel)
        {
            this.ISBNnr = isbn;
            this.Titel = titel;
            this.Bokning = null;
        }

        public override string ToString()
        {
            return ISBNnr + " " + Titel;
        }

    }
}
