using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProjectPD_34
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public Person(string Name, string SurName, int Age)
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
