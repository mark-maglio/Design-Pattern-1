using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
    public class Tabella
    {
        List<Riga> righe = new List<Riga>();

        public Tabella() { }

        public Riga NuovaRiga()
        {
            Riga r = new Riga();
            righe.Add(r);
            return r;
        }
    }
}
