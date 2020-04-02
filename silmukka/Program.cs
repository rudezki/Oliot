using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Elaimet;

namespace silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 1;
            List<Elain> elukat = new List<Elain>();
            Console.WriteLine("Kuinka monta eläintä luodaan?");
            int maara = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maara; i++)
            {
                if (i % 4 == 0)
                {
                    Nisakkaat elukka = new Hevonen();
                    elukka.AsetaElaimenNimi("heppa");
                    elukka.AsetaElaimenIka(5);
                    elukka.AsetaOnLihanSyoja(false);
                    elukka.AsetaOnKohtu(true);
                    elukat.Add(elukka);
                    q++;
                    if (q == 4)
                    {
                        q = 1;
                    }
                }
                else if (q == 1)
                {
                    Nisakkaat elukka = new Kissa();
                    elukka.AsetaElaimenNimi("kissa");
                    elukka.AsetaElaimenIka(2);
                    elukka.AsetaOnLihanSyoja(true);
                    elukka.AsetaOnKohtu(true);
                    elukat.Add(elukka);
                    q++;
                }
                else if (q == 2)
                {
                    Nisakkaat elukka = new Koira();
                    elukka.AsetaElaimenNimi("koira");
                    elukka.AsetaElaimenIka(1);
                    elukka.AsetaOnLihanSyoja(true);
                    elukka.AsetaOnKohtu(true);
                    elukat.Add(elukka);
                    q++;
                }
                else if (q == 3)
                {
                    Linnut elukka = new Papukaija();
                    elukka.AsetaElaimenNimi("kaija");
                    elukka.AsetaElaimenIka(20);
                    elukka.AsetaOnLihanSyoja(false);
                    elukka.AsetaOnKloaakki(true);
                    elukat.Add(elukka);
                    q = 1;
                }
            }
            foreach (Linnut kaija in elukat.OfType<Papukaija>())
            {
                Console.WriteLine(kaija.PalautaElaimenIka);
                Console.WriteLine(kaija.PalautaElaimenNimi);
                kaija.PalautaOnLihanSyoja();
                kaija.PalautaOnKloaakki();
            }
            foreach (Nisakkaat kissa in elukat.OfType<Kissa>())
            {
                Console.WriteLine(kissa.PalautaElaimenIka);
                Console.WriteLine(kissa.PalautaElaimenNimi);
                kissa.PalautaOnLihanSyoja();
                kissa.PalautaOnKohtu();
            }
            foreach (Nisakkaat koira in elukat.OfType<Koira>())
            {
                Console.WriteLine(koira.PalautaElaimenIka);
                Console.WriteLine(koira.PalautaElaimenNimi);
                koira.PalautaOnLihanSyoja();
                koira.PalautaOnKohtu();
            }
            foreach (Nisakkaat heppa in elukat.OfType<Hevonen>())
            {
                Console.WriteLine(heppa.PalautaElaimenIka);
                Console.WriteLine(heppa.PalautaElaimenNimi);
                heppa.PalautaOnLihanSyoja();
                heppa.PalautaOnKohtu();
            }
            
            Console.ReadKey();
        }

    }
}
