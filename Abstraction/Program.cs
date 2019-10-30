using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstractClass = new SecondAbsClass(); //AbstractClass'ın nesnesi oluşturulmaz.SecondAbsClasstan türetilir.
            abstractClass.Metot_0();
            abstractClass.Metot_1();
            abstractClass.Metod_2_virtual();
            Console.WriteLine("Hello World!");
        }
    }
}
