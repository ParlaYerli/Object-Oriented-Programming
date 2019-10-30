using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Aslan : IEtcil
    {
        public string name { get; set; }
        public Aslan()
        {

        }
        public Aslan(string _name)
        {
            name = _name;
        }
        public void BeslenmeSekli()
        {
            Console.WriteLine("Etcil bir hayvanım  :  " + name);
        }
    }
}

