using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Elaimet
{
    public class Kissa : Nisakkaat
    {
        private string name = "kissa";
        public Kissa(int age, string name)
        {

        }
        public Kissa()
        {

        }

        public void Kehraa()
        {
            Console.WriteLine("Hrrrr");
        }
        public override void Aantelee()
        {
            Console.WriteLine("Miau!");
        }
    }
    
}
