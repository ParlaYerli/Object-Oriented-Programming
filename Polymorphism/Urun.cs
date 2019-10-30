using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public virtual double KdvUygula()
        {
            return Fiyat * 1.08;
        }

        public Urun()
        {

        }
        public Urun(string ad, double fiyat)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
        }

        
    }
}
