using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Nisakkaat : Elain
    {
        private bool kohtu;
        public void asetaOnKohtu(bool onkoKohtu)
        {
            this.kohtu = onkoKohtu;
        }
        public bool palautaOnKohtu()
        {
            return this.kohtu;
        }
    }
}
