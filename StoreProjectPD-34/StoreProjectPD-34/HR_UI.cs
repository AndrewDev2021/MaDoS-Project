using System;

namespace StoreProjectPD_34
{
    class HR_UI 
    {
        public HRService _hRService;

        public HR_UI(HRService hRService)
        {
            this._hRService = hRService;
        }

        public void CreateEmployee()
        {
            Console.Write("in CreateEmployee name?: ");
            string name = Console.ReadLine();
            Console.Write("CreateEmployee surname?: ");
            string surName = Console.ReadLine();
            Console.Write("CreateEmployee age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            _hRService.CreateHR(new HR(name, surName, age));
        }
    }
}