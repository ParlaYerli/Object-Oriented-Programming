using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Ayi : IEtcil, IOtcul
    {
        public string name { get; set; }
        public Ayi(string _name)
        {
            name = _name;
        }
        public Ayi()
        {

        }
        public void BeslenmeSekli()
        {
            Console.WriteLine("Hem etcil hem otcul bir hayvanım  :  " + name);
        }
    }
}
