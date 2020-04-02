using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
using Elaimet;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luot luokasta olion
            Hevonen Alma = new Hevonen();

            //Tulosta olion nimi ja paino
            Console.WriteLine(Alma.Nimi + " " + Alma.Paino + " kg");

            //Muuta olion nimeä ja painoa
            Alma.Nimi = "Alma";
            Alma.Paino = 226;

            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            


            Console.WriteLine(Alma.Nimi + " " + Alma.Paino + " kg");
            //Ota Uusi Kissa-luokka Program.cs:ssä käyttöön luomalla uusi kissa - olio parametrittomalla konstruktorilla.

            Kissa Murre = new Kissa();


            //2.Anna sen jälkeen kissalle nimi suoraan public muuttujalla.

            Murre.PalautaElaimenNimi = "Jarno";

            Console.WriteLine(Murre.PalautaElaimenNimi);

            Murre.AsetaElaimenNimi("Murre");

            //3. Tulosta kissan nimi.

            Console.WriteLine(Murre.PalautaElaimenNimi);




            //6. Tulosta kissan ikä.

            Console.WriteLine(Murre.PalautaElaimenIka);

            //7. Tee uusi kissa-olio ja anna ikä ja nimi konstruktorissa.

            Elain Vinski = new Kissa(12, "Vinski");

            //8. Tulosta uuden olion tiedot nimi ja ikä.

            Console.WriteLine(Vinski.PalautaElaimenNimi + " " + Vinski.PalautaElaimenIka);


            //Luo uusi kissa - olio.

            Kissa anneli = new Kissa();

            //ii.Aseta kissan nimeksi ensin "Anneli" ja tulostat onnistuuko se vai ei

            anneli.AsetaElaimenNimi("Anneli");

            //iii.Tulosta perään olion kissan sen hetkinen nimi

            Console.WriteLine(anneli.PalautaElaimenNimi);

            //iv.Asetat kissan nimeksi "Hilda" ja tulostat onnistuuko se vai ei

            anneli.AsetaElaimenNimi("Hilda");

            //v.Tulostat perään olion kissan sen hetkisen nimen

            Console.WriteLine(anneli.PalautaElaimenNimi);

            //  Luo uusi koira - olio.

            Koira koiruli = new Koira();

            //	Aseta koiran nimeksi ensin "Max" ja tulostat onnistuuko se vai ei

            koiruli.AsetaElaimenNimi("Max");

            //  Tulosta perään olion koiran sen hetkinen nimi

            Console.WriteLine(koiruli.PalautaElaimenNimi);

            //  Asetat koiran nimeksi "musti" ja tulostat onnistuuko se vai ei

            koiruli.AsetaElaimenNimi("musti");

            //  Tulostat perään olion koiran sen hetkisen nimen

            Console.WriteLine(koiruli.PalautaElaimenNimi);

            //Testataan koiran ääntelyä.
            koiruli.Aantelee();
            anneli.Aantelee();

            //Luodaan Elain-olio.
            //Elain jussi = new Elain(); Ei enää toimi
            //jussi.Aantelee();

            //5) Luodaan uusi Koira-olio ja asetetaan sille vain nisäkkäille kuuluva ominaisuus
            Koira elmo = new Koira();
            elmo.AsetaElaimenNimi("Elmo");
            elmo.AsetaElaimenIka(10);
            elmo.AsetaOnKohtu(true);

            //6) Luodaan uusi Papukaija - olio ja asetataan sille: nimi, ikä ja vain linnuille kuuluva ominaisuus
            Papukaija ronski = new Papukaija();
            ronski.AsetaElaimenNimi("Ronski");
            ronski.AsetaOnKloaakki(true);
            ronski.AsetaElaimenIka(10);

            //7) Tulostetaan molempien nimi, ikä sekä erikoisominaisuuden arvo.
            Console.WriteLine(elmo.PalautaElaimenNimi);
            Console.WriteLine(elmo.PalautaElaimenIka + "v");
            if (elmo.PalautaOnKohtu())
            {
                Console.WriteLine("Eläimellä on kohtu.");
            }
            else
            {
                Console.WriteLine("Eläimellä ei ole kohtua.");
            }
            Console.WriteLine(ronski.PalautaElaimenNimi);
            Console.WriteLine(ronski.PalautaElaimenIka + "v");
            ronski.PalautaOnKloaakki();

            //pennuille tehdään emo ja lisätään sille kolme pentua.
            List<Kissa> pennut = new List<Kissa>();
            Kissa mutsi = new Kissa();
            mutsi.AsetaElaimenNimi("mutsi");
            Kissa koira = new Kissa();
            koira.AsetaElaimenNimi("mursu");
            koira.AsetaElaimenIka(0);
            pennut.Add(koira);
            Kissa koira1 = new Kissa();
            koira1.AsetaElaimenNimi("pupper");
            koira1.AsetaElaimenIka(0);
            pennut.Add(koira1);
            Kissa koira2 = new Kissa();
            koira2.AsetaElaimenNimi("doggo");
            koira2.AsetaElaimenIka(0);
            pennut.Add(koira2);
            koira.LisaaEmo(mutsi);
            koira1.LisaaEmo(mutsi);
            koira2.LisaaEmo(mutsi);
            //Lisätään pennut emon kanssa listaan.
            mutsi.LisaaPentu(pennut, mutsi);
            mutsi.TulostaPennut();

            //Luodaan uusi lista pennuista ja uusi emo.

            List<Kissa> pennut2 = new List<Kissa>();
            Kissa perskeles = new Kissa();
            perskeles.AsetaElaimenIka(6);
            perskeles.AsetaElaimenNimi("Vilma");
            Kissa pentti = new Kissa();
            pentti.AsetaElaimenIka(0);
            pentti.AsetaElaimenNimi("pentti");
            pennut2.Add(pentti);
            Kissa pena = new Kissa();
            pena.AsetaElaimenIka(0);
            pena.AsetaElaimenNimi("pena");
            pennut2.Add(pena);
            Kissa pentele = new Kissa();
            pentele.AsetaElaimenIka(0);
            pentele.AsetaElaimenNimi("pentele");
            pennut2.Add(pentele);
            perskeles.LisaaPentu(pennut2, perskeles);
            perskeles.TulostaPennut();
            
            Console.ReadKey();
        }
}
}
