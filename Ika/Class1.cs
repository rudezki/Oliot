using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elaimet;

namespace Ika
{
    public class Ika
    {
        public void Ages()
        {
            Random rand = new Random();
            //    1. Tee silmukka, joka menee ympäri 10 kertaa.
            for (int i = 0; i < 10; i++)
            {
                //2. Silmukan sisällä:
                //   3. Luo aina yhden koira- ja kissa-olion.

                Koira koiruli = new Koira();
                Kissa kisuli = new Kissa();

                //   4. Arvo ikä koiralle välillä 1-15
                //   5. Arvo ikä kissalle välillä 1-10
                //   6. Aseta iät koiran ja kissan oliolle.

                koiruli.AsetaKoiranIka(rand.Next(1, 15));
                kisuli.AsetaKissanIka(rand.Next(1, 10));

                //   7. Vertaile if-lausella koira ja kissaolioiden ikiä
                //     - Tulosta ensin: "Koira on: xx vuotta, Kissa on: xx vuotta", jossa xx on arvottu ikä.
                Console.WriteLine("Koira on: " + koiruli.Ika + " vuotta, Kissa on: " + kisuli.Ika + " vuotta");

                //     - Ota ikä koiran ja kissan metodeilta, palautaKissanIka() ja palautaKoiranIka()
                if (koiruli.Ika > kisuli.Ika)
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else if (kisuli.Ika > koiruli.Ika)
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
        }
    
  
   

    }
}
