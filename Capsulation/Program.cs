using System;

namespace Capsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Capsul capsul = new Capsul();
            capsul.Name = "Parla";
            capsul.Surname = "Yerli";
            capsul.TelNo = 3253094;
            capsul.Job = "Software Developer";

            Console.WriteLine("" + capsul.Name);
            Console.WriteLine("" + capsul.Surname);
            Console.WriteLine("" + capsul.TelNo);
            Console.WriteLine("" + capsul.Job);
          
        }
    }
}
