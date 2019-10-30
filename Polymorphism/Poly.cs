using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Poly
    {
        public string Name { get; set; }

        public virtual void Selam()
        {
            Console.WriteLine("Selamlaaaar " + Name);
        }


    }
}
