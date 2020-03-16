using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elaimet;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa mila = new Kissa();
            mila.asetaElaimenNimi("Mila");
            mila.asetaElaimenIka(10);
            mila.asetaOnLihanSyoja(true);
            Console.WriteLine(mila.palautaElaimenNimi + ", " + mila.palautaElaimenIka);
        }
    }
}
