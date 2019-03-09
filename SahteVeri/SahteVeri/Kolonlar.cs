using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    class Kolonlar
    {
        
        
          
        Random rando;
        public Kolonlar()
        {
            rando = new Random();
        }
        internal string RastgeleIsim()
        {
            string[] Adlar = { "Fevzi", "Emel", "İpek", "Doğan", "Utku", "Elçin", "Kemal", "Demet", "Nazlı", "Gülten" };
            int rand = rando.Next(0, 10);
            return Adlar[rand];
        }
         public string RastgeleSoyIsim()
        {
            string[] SoyAdlar = { "Soylu", "Tembel", "Uçar", "Şükran", "Odayeri", "Keskin", "Kapıcı", "Minik", "Büyük", "Küçük" };
            int rand = rando.Next(0, 10);
            return SoyAdlar[rand];
        } 
        protected internal int RastgeleYas()  //protected internal aynı proje içinde public gibi davranır.
        {
            int[] Yaslar = { 52, 24, 26, 41, 33, 56, 21, 35, 19, 28 };
            int rand = rando.Next(0, 10);
            return Yaslar[rand];
        }
        protected internal int RastgeleNot()
        {
            int[] Notlar = { 95, 65, 85, 15, 03, 100, 70, 75, 86, 45 };
            int rand = rando.Next(0, 10);
            return Notlar[rand];
        }
    }
}
