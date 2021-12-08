using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProjectPD_34
{
    class Person
    {
        protected string Name { get; set; }
        protected string SurName { get; set; }
        protected int Age { get; set; }

        public Person(String Name, String SurName, int Age)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Age = Age;
        }

        public override string ToString()
        {
            return String.Format(Name + " " + SurName + " " + Age);
        }
    }
}
