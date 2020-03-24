using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Papukaija : Linnut
    {
        private string name = "kaija";
        public Papukaija(int age, string name)
        {

        }
        public Papukaija()
        {

        }
        public override void Aantelee()
        {
            Console.WriteLine("Kraak!");
        }
    }
}
