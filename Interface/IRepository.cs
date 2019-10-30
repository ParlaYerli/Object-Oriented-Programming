using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IRepository
    {
        void Insert();
        void Update();
        void Delete();
        void Save();
    }
}
