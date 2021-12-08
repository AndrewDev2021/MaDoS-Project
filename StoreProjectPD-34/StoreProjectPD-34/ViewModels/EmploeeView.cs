using StoreProjectPD_34.Models.Common;
using System;

namespace StoreProjectPD_34.ViewModels
{
    public class EmploeeView : IId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format(Id + " " + Name + " " + SurName + " " + Age);
        }
    }
}