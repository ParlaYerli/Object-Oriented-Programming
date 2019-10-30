using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class AbstractClass
    {
        public string a = ""+ "bu bir ABSTRACT CLASSın string propertysidir" + " ";
        public void Metot_0()
        {
            Console.WriteLine("Abstract Sınıf içerisinde normal metot çalıştı");
        }
        public virtual void Metod_2_virtual()
        {
            Console.WriteLine("Varsayılan olarak belirlenen metot ama değişim yapmak için VIRTUAL kelimesini eklemek gerekiyor");
        }
        public abstract void Metot_1(); // metot içi doldurulunca hata veriyor , sadece tanımlamak lazım.
    }
}
