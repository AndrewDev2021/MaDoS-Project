using System.Collections.Generic;

namespace StoreProjectPD_34
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
