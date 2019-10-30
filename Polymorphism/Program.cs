using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Poly poly = new Poly();
            poly.Name = "Parla";
            poly.Selam();
            PolyKullan polyKullan = new PolyKullan();
            polyKullan.Name = "Ayşe";
            polyKullan.Selam();



            Sepet sepet = new Sepet();
            Tekstil tekstil = new Tekstil("Gömlek", 40, 36, "Koton");
            sepet.Ekle(tekstil);
            Console.WriteLine(""+ sepet.ToplamTutar());

        }
    }
}
