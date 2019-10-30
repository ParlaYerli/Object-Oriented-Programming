using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Aslan aslan = new Aslan();
            aslan.name = "aslan";
            aslan.BeslenmeSekli();

            Ayi ayi = new Ayi();
            ayi.name = "ayi";
            ayi.BeslenmeSekli();


            Kuzu kuzu = new Kuzu();
            kuzu.name = "kuzu";
            kuzu.BeslenmeSekli();

            MySQL mySQL = new MySQL();
            mySQL.Insert();
            mySQL.Update();

            Oracle oracle = new Oracle();
            oracle.Save();
            oracle.Delete();
            
        }
    }
}
