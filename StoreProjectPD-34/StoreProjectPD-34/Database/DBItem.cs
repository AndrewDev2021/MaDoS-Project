using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProjectPD_34.Database
{
    internal class DBItem<T> : IDBItem<T>
    {
        public List<T> Items { get; set; }
        public DBItem()
        {
            Items = new List<T>();
        }

        public void AddItem(T item) { Items.Add(item); }

    }
}
