using StoreProjectPD_34.Models.Common;
using System;

namespace StoreProjectPD_34.Models
{
    class Customer : Person, IId
    {
        private static int counter = 1;

        public int Id { get; set; }

        public Customer(string Name, string SurName, int Age) : base(Name, SurName, Age)
        {
            Id = counter++;
        }

        public override string ToString()
        {
            return string.Format(Id + " " + base.ToString());
        }
    }
}
