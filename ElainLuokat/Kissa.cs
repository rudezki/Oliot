using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Elaimet
{
    public class Kissa : Nisakkaat
    {
        private List<Kissa> kissat = new List<Kissa>();
        private List<Kissa> pennut = new List<Kissa>();
        private List<Kissa> pentujenTiedot = new List<Kissa>();
        private Kissa emo;
        private int pentujenMaara = 0;
        public Kissa(int age, string nimi)
        {

        }
        public Kissa(Kissa kisu)
        {

        }
        public Kissa()
        {
            this.pentujenMaara = 0;

        }
        public void LisaaPentu(List<Kissa> pentuja, Kissa mutsi)
        {
            this.pentujenMaara++;
            foreach (Kissa pentu in pentuja)
            {
                pentu.LisaaEmo(mutsi);
                pennut.Add(pentu);
                pentujenTiedot.Add(pentu);
            }
        }

        public void LisaaEmo(Kissa mom)
        {
            emo = mom;
        }

        public Kissa PalautaEmo()
        {
            return emo;
        }

        public void Kehraa()
        {
            Console.WriteLine("Hrrrr");
        }
        public override void Aantelee()
        {
            Console.WriteLine("Miau!");
        }
        
        public void TulostaPennut()
        {
            //  Console.WriteLine(emo.PalautaElaimenNimi + ", " + emo.PalautaElaimenIka);
            foreach (Kissa pentu in pentujenTiedot)
            {
                Console.WriteLine(pentu.PalautaElaimenNimi + ", " + pentu.PalautaElaimenIka + ", " + pentu.emo.PalautaElaimenNimi);
            }
        }
    }
    
}
