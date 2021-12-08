using StoreProjectPD_34.Models;
using StoreProjectPD_34.Services;
using System;
using System.Linq;

namespace StoreProjectPD_34.UI
{
    class HR_UI
    {
        public HRService _hRService;

        public HR_UI(HRService hRService)
        {
            _hRService = hRService;
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

        public void showEmployee()
        {
            var employees = _hRService.GetEmploees();

            employees.ToList().ForEach(employee =>
            {
                Console.WriteLine(employee.ToString());
            });
        }


    }
}