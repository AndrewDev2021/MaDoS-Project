using System.Collections.Generic;

namespace StoreProjectPD_34.Database
{
    internal interface IDBItem<T>
    {
        List<T> Items { get; set; }

        void AddItem(T item);
    }
}