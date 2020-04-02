using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elaimet;
using ElainLuokat;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa mila = new Kissa();
            mila.AsetaElaimenNimi("Mila");
            mila.AsetaElaimenIka(10);
            mila.AsetaOnLihanSyoja(true);
            Console.WriteLine(mila.PalautaElaimenNimi + ", " + mila.PalautaElaimenIka + " vuotta. ");
            mila.PalautaOnLihanSyoja();
            mila.Kehraa();

            Koira rico = new Koira();
            rico.AsetaElaimenNimi("Rico");
            rico.AsetaElaimenIka(6);
            rico.AsetaOnLihanSyoja(true);
            Console.WriteLine(rico.PalautaElaimenNimi + ", " + rico.PalautaElaimenIka);
            rico.PalautaOnLihanSyoja();
            Console.ReadKey();
            
        }
    }
}

