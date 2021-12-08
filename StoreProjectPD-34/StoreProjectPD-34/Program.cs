using System;

namespace StoreProjectPD_34
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();
            HRService hRService = new HRService(db);
            HR_UI hR_UI = new HR_UI(hRService);

            hR_UI.showEmployee();
            //foreach(Emploee e in db.DbEmploee.Items )
            //{
            //    Console.WriteLine(e);
            //}
        }
    }
}
