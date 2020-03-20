using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Elaimet
{
    public class Koira : Nisakkaat
    {
        public Koira(int age, string name)
        {

        }
        public Koira()
        {

        }
        public override void Aantelee()
        {
            Console.WriteLine("Hau!");
        }
    }

}
