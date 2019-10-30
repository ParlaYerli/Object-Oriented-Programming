using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class MySQL : IRepository
    {
        public void Delete()
        {
            Console.WriteLine("MySQL -> delete() metodu çalıştı.");
        }

        public void Insert()
        {
            Console.WriteLine("MySQL L -> insert() metodu çalıştı.");
        }

        public void Save()
        {
            Console.WriteLine("MySQL -> save() metodu çalıştı.");
        }

        public void Update()
        {
            Console.WriteLine("MySQL -> update() metodu çalıştı.");
        }
    }
}
