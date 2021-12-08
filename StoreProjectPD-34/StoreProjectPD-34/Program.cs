using System;

namespace StoreProjectPD_34
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();
            foreach(Emploee e in db.DbEmploee.Items )
            {
                Console.WriteLine(e);
            }
        }
    }
}
