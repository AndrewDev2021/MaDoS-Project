using System.Collections.Generic;

namespace Modeling_and_Project_Software
{
    internal interface IDBItem<T>
    {
        List<T> Items { get; set; }

        void AddItem(T item);
    }
}