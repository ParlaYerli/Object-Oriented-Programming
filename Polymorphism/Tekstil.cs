using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Tekstil : Urun
    { // eğer Urunun ctoru parametresiz olanı yapmazsak burada hata veriyor.
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }
        public override double KdvUygula()
        {
            return Fiyat* 0.50;
        }
        public Tekstil(string ad, int fiyat, int beden, string firma)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            Beden = beden;
            UreticiFirma = firma;
        }

    }
}
