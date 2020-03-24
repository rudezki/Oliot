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
        public void palautaOnKloaakki()
        {
            if (this.cloaca)
            {
                Console.WriteLine("Eläimellä on kloaakki");
            }
            else
            {
                Console.WriteLine("Eläimellä ei ole kloaakkia");
            }
        }
    }
}
