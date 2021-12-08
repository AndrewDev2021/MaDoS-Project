using StoreProjectPD_34.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProjectPD_34.Models
{
    class Emploee : Person, IId
    {
        private static int counter = 1;

        public int Id { get; set; }

        public Emploee(string Name, string SurName, int Age) : base(Name, SurName, Age)
        {
            Id = counter++;
        }

        public override string ToString()
        {
            return string.Format(Id + " " + base.ToString());
        }
    }
}
