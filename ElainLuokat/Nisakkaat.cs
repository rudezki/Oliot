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
        public void AsetaOnKohtu(bool onkoKohtu)
        {
            this.kohtu = onkoKohtu;
        }
        public bool PalautaOnKohtu()
        {
            return this.kohtu;
        }
    }
}
