using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Linnut : Elain
    {
        private bool cloaca;
        public void asetaOnKloaakki(bool setkloaakki)
        {
            this.cloaca = setkloaakki;
        }
        public bool palautaOnKloaakki()
        {
            return this.cloaca;
        }
    }
}
