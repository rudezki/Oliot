using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

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

            Murre.palautaElaimenNimi = "Jarno";

            Console.WriteLine(Murre.palautaElaimenNimi);

            Murre.asetaElaimenNimi("Murre");

            //3. Tulosta kissan nimi.

            Console.WriteLine(Murre.palautaElaimenNimi);




            //6. Tulosta kissan ikä.

            Console.WriteLine(Murre.palautaElaimenIka);

            //7. Tee uusi kissa-olio ja anna ikä ja nimi konstruktorissa.

            Elain Vinski = new Kissa(12, "Vinski");

            //8. Tulosta uuden olion tiedot nimi ja ikä.

            Console.WriteLine(Vinski.palautaElaimenNimi + " " + Vinski.palautaElaimenIka);


            //Luo uusi kissa - olio.

            Kissa anneli = new Kissa();

            //ii.Aseta kissan nimeksi ensin "Anneli" ja tulostat onnistuuko se vai ei

            anneli.asetaElaimenNimi("Anneli");

            //iii.Tulosta perään olion kissan sen hetkinen nimi

            Console.WriteLine(anneli.palautaElaimenNimi);

            //iv.Asetat kissan nimeksi "Hilda" ja tulostat onnistuuko se vai ei

            anneli.asetaElaimenNimi("Hilda");

            //v.Tulostat perään olion kissan sen hetkisen nimen

            Console.WriteLine(anneli.palautaElaimenNimi);

            //  Luo uusi koira - olio.

            Koira koiruli = new Koira();

            //	Aseta koiran nimeksi ensin "Max" ja tulostat onnistuuko se vai ei

            koiruli.asetaElaimenNimi("Max");

            //  Tulosta perään olion koiran sen hetkinen nimi

            Console.WriteLine(koiruli.palautaElaimenNimi);

            //  Asetat koiran nimeksi "musti" ja tulostat onnistuuko se vai ei

            koiruli.asetaElaimenNimi("musti");

            //  Tulostat perään olion koiran sen hetkisen nimen

            Console.WriteLine(koiruli.palautaElaimenNimi);

            //Testataan koiran ääntelyä.
            koiruli.Aantelee();
            anneli.Aantelee();

            //Luodaan Elain-olio.
            Elain jussi = new Elain();
            jussi.Aantelee();


            Console.ReadKey();
        }
}
}
