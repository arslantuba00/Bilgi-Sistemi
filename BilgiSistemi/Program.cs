using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LİSANS");
            Lisans lo1 = new Lisans(); 
            lo1.No= 2008291014;
            lo1.AdSoyad = "Hamiyet Mandıralı";
            lo1.Bolum = "Matematik";
            Console.WriteLine("\t" + lo1.No + ";\t" + lo1.AdSoyad + ";\t" + lo1.Bolum);
            Console.WriteLine("\tDers Bilgileri");
            lo1.DersEkle("Mat101", "Matematik1", 6, 62);
            lo1.DersEkle("Mat107", "Soyut Matematik", 6, 66);
            lo1.DersEkle("FSH333", "Hayat Bilgisi", 8, 60);
            lo1.KumGoster();
            Console.WriteLine("\n");

            Lisans lo2 = new Lisans();
            lo2.No = 2008291022;
            lo2.AdSoyad = "Taner İner";
            lo2.Bolum = "Astrofizik";
            Console.WriteLine("\t" + lo2.No + ";\t" + lo2.AdSoyad + ";\t" + lo2.Bolum);
            Console.WriteLine("\tDers Bilgileri");
            lo2.DersEkle("Mat101", "Matematik1\t", 6, 95);
            lo2.DersEkle("Mat107", "Soyut Matematik\t", 6, 90);
            lo2.DersEkle("FSH333", "Hayat Bilgisi\t", 8, 100);
            lo2.DersEkle("AST101", "Astrofiziğe Giriş", 12, 88);
            lo2.KumGoster();
            Console.WriteLine("\n");

            Console.WriteLine("YÜKSEK LİSANS");   
            YuksekLisans ylo1 = new YuksekLisans();
            ylo1.No = 2009291062;
            ylo1.AdSoyad = "Adil Kemal Kükrer";
            ylo1.Bolum = "Tarih";
            Console.WriteLine("\t" + ylo1.No + ";\t" + ylo1.AdSoyad + ";\t" + ylo1.Bolum);
            YuksekLisans lb1 = new YuksekLisans("İstanbul Üniversitesi","Tarih");
            Console.WriteLine("\tDers Bilgileri");
            ylo1.DersEkle("TAR505", "Tatar Tarihi", 18, 79);
            ylo1.DersEkle("TAR511", "Uzakdoğu Tarihi", 18, 100);
            ylo1.KumGoster();
            Console.WriteLine("\n");

            YuksekLisans ylo2 = new YuksekLisans();
            ylo2.No = 2010432000;
            ylo2.AdSoyad = "Senem Bilgiç";
            ylo2.Bolum = "Bilgisayar Bilimleri";
            Console.WriteLine("\t" + ylo2.No + ";\t" + ylo2.AdSoyad + ";\t" + ylo2.Bolum);
            YuksekLisans lb2 = new YuksekLisans("Dokuz Eylül Üniversitesi", "Bilgisayar Bilimleri");
            Console.WriteLine("\tDers Bilgileri");
            ylo2.DersEkle("CSC5001", "Fuzzy Data Analysis\t\t", 8, 78);
            ylo2.DersEkle("CSC5019", "Software Requirements Engineering", 8, 40);
            ylo2.DersEkle("MAT5101", "Applied Mathematics\t\t", 9, 83);
            ylo2.KumGoster();
            Console.WriteLine("\n");

            Console.WriteLine("DOKTORA");
            Doktora dko1 = new Doktora();
            dko1.No = 2009291030;
            dko1.AdSoyad = "Doğaç Sazan";
            dko1.Bolum = "Spor Bilimleri";
            Console.WriteLine("\t" + dko1.No + ";\t" + dko1.AdSoyad + ";\t" + dko1.Bolum);
            Doktora ylb1 = new Doktora("Ege Üniversitesi", "Beden Eğitimi ve Spor", "UNIVERSITY OF BRITISH COLUMBIA", "KINESIOLOGY");
            Console.WriteLine("\tDers Bilgileri");
            dko1.DersEkle("SPB603", "Rehabilitatif Spor", 18, 95);
            dko1.DersEkle("SPB630", "Sporda Sponsorluk", 6, 100);
            dko1.KumGoster();
            Console.WriteLine("\n");

            Doktora dko2 = new Doktora();
            dko2.No = 2011789078;
            dko2.AdSoyad = "Perihan Yılmaz";
            dko2.Bolum = "İşletme";
            Console.WriteLine("\t" + dko2.No + ";\t" + dko2.AdSoyad + ";\t" + dko2.Bolum);
            Doktora ylb2 = new Doktora("Pamukkale Üniversitesi", "Maliye", "Osmangazi Üniversitesi", "İşletme");
            Console.WriteLine("\tDers Bilgileri");
            dko2.DersEkle("HUK458", "Borçlar Hukuku", DersNotu:80);
            dko2.DersEkle("ISL693", "Mikro İktisat", 4, 74);
            dko2.DersEkle("ISL694", "Makro İktisat", DersNotu:60);
            dko2.KumGoster();

            Console.ReadKey();
            
        }
    }
}
