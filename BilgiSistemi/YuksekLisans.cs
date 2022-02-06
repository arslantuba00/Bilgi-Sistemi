using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiSistemi
{
    class YuksekLisans:Lisans
    {
        protected string mezunLisansUniversite;
        protected string mezunLisansBolum;

        public YuksekLisans(){}

        internal YuksekLisans(string _mezunLisansUniversite, string _mezunLisansBolum)
        {
            this.mezunLisansUniversite = _mezunLisansUniversite;
            this.mezunLisansBolum = _mezunLisansBolum;
            Console.WriteLine("\tLisans Bilgileri");
            Console.WriteLine("\t\t" + mezunLisansUniversite.ToUpper() + ";\t" + mezunLisansBolum.ToUpper());
        }

    }
}
