using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Sepet
    {
        public List<Urun> urunler = new List<Urun>();
        public double ToplamTutar()
        {
            double tutar = 0;
            foreach (Urun item in urunler)
            {
                tutar += item.KdvUygula();
            }

            return tutar;
        }

        public void Ekle(Urun yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
