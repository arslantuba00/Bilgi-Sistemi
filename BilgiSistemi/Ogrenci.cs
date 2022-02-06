using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiSistemi
{
    class Ogrenci
    {
        private int no;
        private string adSoyad;
        private string bolum;

        protected string dersKodu;
        protected string dersAdi;
        protected int dersKredisi;
        protected int dersNotu;
    
        internal double krediBasariNotu = 0.0;
        internal double krediToplam = 0.0;
        internal double kumOrt = 0.0;

        public int No
        {
            get { return no; }
            set { no = value; }
        }
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value.ToUpper(); }
        }
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value.ToUpper(); }
        }
 
        internal void DersEkle(string DersKodu="N/A", string DersAdi="N/A", int DersKredisi=5, int DersNotu=0)
        {
            this.dersKodu = DersKodu;
            this.dersAdi = DersAdi;
            this.dersKredisi = DersKredisi;
            this.dersNotu = DersNotu;

            krediBasariNotu += (dersKredisi * dersNotu);
            krediToplam += dersKredisi;
            kumOrt = krediBasariNotu / krediToplam;

            Console.WriteLine("\t\t" + dersKodu + "\t\t" + dersAdi + "\t\t\t" + dersKredisi + " AKTS\t\t" + dersNotu);          
        }

        public void KumGoster()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tKümülatif Ortalama: {0:0.00}", kumOrt);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
