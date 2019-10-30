using System;
using System.Collections.Generic;
using System.Text;

namespace Capsulation
{
    class Capsul
    {
        string name;
        string surname;
        int telno;
        string job;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int TelNo
        {
            get { return telno; }
            set { telno = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }


    }
}
