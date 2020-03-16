using System;
using Elaimet;
using ElainLuokat;

namespace Ika1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //    1. Tee silmukka, joka menee ympäri 10 kertaa.
            for (int i = 0; i < 10; i++)
            {
                //2. Silmukan sisällä:
                //   3. Luo aina yhden koira- ja kissa-olion.

                Elain koiruli = new Koira();
                Elain kisuli = new Kissa();

                //   4. Arvo ikä koiralle välillä 1-15
                //   5. Arvo ikä kissalle välillä 1-10
                //   6. Aseta iät koiran ja kissan oliolle.

                koiruli.asetaElaimenIka(rand.Next(1, 15));
                kisuli.asetaElaimenIka(rand.Next(1, 10));

                //   7. Vertaile if-lausella koira ja kissaolioiden ikiä
                //     - Tulosta ensin: "Koira on: xx vuotta, Kissa on: xx vuotta", jossa xx on arvottu ikä.
                Console.WriteLine("Koira on: " + koiruli.palautaElaimenIka + " vuotta, Kissa on: " + kisuli.palautaElaimenIka + " vuotta");

                //     - Ota ikä koiran ja kissan metodeilta, palautaKissanIka() ja palautaKoiranIka()
                if (koiruli.palautaElaimenIka > kisuli.palautaElaimenIka)
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else if (kisuli.palautaElaimenIka > koiruli.palautaElaimenIka)
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
                else
                {
                    Console.WriteLine("kummatkin ovat samanikäisiä.");
                }
                //     - Jos koira on vanhempi, tulosta "Koira on vanhempi"
                //     - Jos kissa on vanhempi, tulosta "Kissa on vanhempi"
            }

            Console.ReadLine();
        }
    }
}
