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
            mila.asetaElaimenNimi("Mila");
            mila.asetaElaimenIka(10);
            mila.asetaOnLihanSyoja(true);
            Console.WriteLine(mila.palautaElaimenNimi + ", " + mila.palautaElaimenIka + " vuotta. ");
            mila.palautaOnLihanSyoja();
            mila.Kehraa();

            Koira rico = new Koira();
            rico.asetaElaimenNimi("Rico");
            rico.asetaElaimenIka(6);
            rico.asetaOnLihanSyoja(true);
            Console.WriteLine(rico.palautaElaimenNimi + ", " + rico.palautaElaimenIka);
            rico.palautaOnLihanSyoja();
            Console.ReadKey();
            
        }
    }
}

