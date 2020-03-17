using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Elain
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
        public void asetaElaimenIka(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
        }
        public void asetaElaimenNimi(string name)
        {
            this.name = name;
        }
        public void palautaOnLihanSyoja()
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
        public void asetaOnLihanSyoja(bool lihis)
        {
            this.onLihanSyoja = lihis;
        }
        public string palautaElaimenNimi
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
        public int palautaElaimenIka
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
    }
}
