using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Oracle : IRepository
    {
        public void Delete()
        {
            Console.WriteLine("Oracle -> delete() metodu çalıştı.");
        }

        public void Insert()
        {
            Console.WriteLine("Oracle -> insert() metodu çalıştı.");
        }

        public void Save()
        {
            Console.WriteLine("Oracle -> save() metodu çalıştı.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle -> update() metodu çalıştı.");
        }
    }
}
