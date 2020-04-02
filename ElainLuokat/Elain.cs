using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int age = 0;
        private string name;
        private bool onLihanSyoja;
        public Elain()
        { }
        public Elain(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void AsetaElaimenIka(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
        }
        public void AsetaElaimenNimi(string name)
        {
            this.name = name;
        }
        public void PalautaOnLihanSyoja()
        {
            if (this.onLihanSyoja)
            {
                 Console.WriteLine("Eläin on lihansyöjä");
            }
            else
            {
                Console.WriteLine("Eläin ei ole lihansyöjä");
            }
        }
        public void AsetaOnLihanSyoja(bool lihis)
        {
            this.onLihanSyoja = lihis;
        }
        public string PalautaElaimenNimi
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int PalautaElaimenIka
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public virtual void Aantelee()
        {
            Console.WriteLine("Umph!");
        }
    }
}
