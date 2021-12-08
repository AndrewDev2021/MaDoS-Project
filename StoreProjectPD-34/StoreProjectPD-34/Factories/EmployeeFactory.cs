using StoreProjectPD_34.Models;
using System.Collections.Generic;

namespace StoreProjectPD_34.Factories
{
    class EmployeeFactory
    {
        public static IEnumerable<Emploee> GetEmploees()
        {
            yield return new Emploee("Bohdan", "Kolav", 19);
            yield return new Emploee("Andrey", "Pob", 18);
            yield return new Emploee("Yaroslav", "Mudriy", 21);
        }
    }
}
