using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad ="hazal";
            ogrenci.Bolum = "reklam tasarımı ve iletişimi";
            ogrenci.Cinsiyet="kadın";
            ogrenci.Okul = "üsküdar üniversitesi";
            ogrenci.Yas = 22;
            ogrenci.Soyad = "yerli";

            Yazilimci yazilimci = new Yazilimci();
            yazilimci.Ad = "Parla";
            yazilimci.Calistigi_Kurum = "Demirören";
            yazilimci.Cinsiyet = "kadın";
            yazilimci.Maas = 1000;
            yazilimci.Yas = 26;
            yazilimci.Soyad = "yerli";
            Console.WriteLine("" + ogrenci.Ad, "" + ogrenci.Soyad);
            Console.WriteLine("" + ogrenci.Bolum);
            Console.WriteLine(""+ ogrenci.Cinsiyet);
            Console.WriteLine(""+ ogrenci.Okul);
            Console.WriteLine(""+ ogrenci.Yas);
            Console.WriteLine("");

            Console.WriteLine(""+ yazilimci.Ad);
            Console.WriteLine("" + yazilimci.Calistigi_Kurum);
            Console.WriteLine(""+ yazilimci.Cinsiyet);
          
            Console.WriteLine(""+ yazilimci.Maas);
            Console.WriteLine(""+ yazilimci.Yas);
           
        }
     }
 }
 

