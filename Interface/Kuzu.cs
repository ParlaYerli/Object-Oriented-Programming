using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Kuzu : IOtcul
    {
        public string name { get; set; }
        public Kuzu()
        {
                
        }
        public Kuzu(string _name)
        {
            name = _name;  
        }
        public void BeslenmeSekli()
        {
            Console.WriteLine("Otcul bir hayvanım  :  " + name);
        }
    }
}
