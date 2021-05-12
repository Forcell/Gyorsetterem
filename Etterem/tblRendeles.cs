using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    public class Rendeles
    {

        public Rendeles(long id, string nev, string telefon, string cim, string rendelve)
        {
            this.id = id;
            this.nev = nev;
            this.telefon = telefon;
            this.cim = cim;
            this.rendelve = rendelve;
        }

        public long id { get; set; }
        public string nev { get; set; }
        public string telefon { get; set; }
        public string cim { get; set; }
        public string rendelve { get; set; }
    }
}
