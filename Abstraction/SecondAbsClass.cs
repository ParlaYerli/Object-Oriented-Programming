using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class SecondAbsClass : AbstractClass
    {
        public string b = "SECONDCLASSın string propertysidir" + " ";
        public override void Metot_1()
        {
            Console.WriteLine("abstract sınıf içerisinde abstract metot çalıştı" +"" +a +"" + ""+ b);
        } // abstract classın propertysini burada kullanabilirsin.
    }
}
