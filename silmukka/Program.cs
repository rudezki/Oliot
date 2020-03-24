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
                    elukka.asetaElaimenNimi("heppa");
                    elukka.asetaElaimenIka(5);
                    elukka.asetaOnLihanSyoja(false);
                    elukka.asetaOnKohtu(true);
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
                    elukka.asetaElaimenNimi("kissa");
                    elukka.asetaElaimenIka(2);
                    elukka.asetaOnLihanSyoja(true);
                    elukka.asetaOnKohtu(true);
                    elukat.Add(elukka);
                    q++;
                }
                else if (q == 2)
                {
                    Nisakkaat elukka = new Koira();
                    elukka.asetaElaimenNimi("koira");
                    elukka.asetaElaimenIka(1);
                    elukka.asetaOnLihanSyoja(true);
                    elukka.asetaOnKohtu(true);
                    elukat.Add(elukka);
                    q++;
                }
                else if (q == 3)
                {
                    Linnut elukka = new Papukaija();
                    elukka.asetaElaimenNimi("kaija");
                    elukka.asetaElaimenIka(20);
                    elukka.asetaOnLihanSyoja(false);
                    elukka.asetaOnKloaakki(true);
                    elukat.Add(elukka);
                    q = 1;
                }
            }
            foreach (Linnut kaija in elukat.OfType<Papukaija>())
            {
                Console.WriteLine(kaija.palautaElaimenIka);
                Console.WriteLine(kaija.palautaElaimenNimi);
                kaija.palautaOnLihanSyoja();
                kaija.palautaOnKloaakki();
            }
            foreach (Nisakkaat kissa in elukat.OfType<Kissa>())
            {
                Console.WriteLine(kissa.palautaElaimenIka);
                Console.WriteLine(kissa.palautaElaimenNimi);
                kissa.palautaOnLihanSyoja();
                kissa.palautaOnKohtu();
            }
            foreach (Nisakkaat koira in elukat.OfType<Koira>())
            {
                Console.WriteLine(koira.palautaElaimenIka);
                Console.WriteLine(koira.palautaElaimenNimi);
                koira.palautaOnLihanSyoja();
                koira.palautaOnKohtu();
            }
            foreach (Nisakkaat heppa in elukat.OfType<Hevonen>())
            {
                Console.WriteLine(heppa.palautaElaimenIka);
                Console.WriteLine(heppa.palautaElaimenNimi);
                heppa.palautaOnLihanSyoja();
                heppa.palautaOnKohtu();
            }
            
            Console.ReadKey();
        }

    }
}
