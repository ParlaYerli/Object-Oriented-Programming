using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Personeller personeller = new Personeller();
            personeller.Adi="mahmut";
            personeller.Soyadi = "bıyıklı";
            personeller.Yas = 31;
            personeller.PersonelEkle(personeller);
            Console.WriteLine("" + personeller.Adi);
            Console.WriteLine("" + personeller.Soyadi);
            Console.WriteLine("" + personeller.Yas);
          
        }
    }
}
