using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiSistemi
{
    class Doktora : YuksekLisans 
    {
        protected string mezunYuksekUniversite;
        protected string mezunYuksekBolum;

        public Doktora() { }

        internal Doktora(string _mezunLisansUniversite, string _mezunLisansBolum, string _mezunYuksekUniversite, string _mezunYuksekBolum) : base(_mezunLisansUniversite,_mezunLisansBolum)
        {
     
            this.mezunYuksekUniversite = _mezunYuksekUniversite;
            this.mezunYuksekBolum = _mezunYuksekBolum;
            Console.WriteLine("\tYuksek Lisans Bilgileri");
            Console.WriteLine("\t\t" + mezunYuksekUniversite.ToUpper() + ";\t" + mezunYuksekBolum.ToUpper());
        }


    }
}
