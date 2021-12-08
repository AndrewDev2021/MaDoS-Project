using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeling_and_Project_Software
{
    internal class DBItem<T> : IDBItem<T>
    {
        public List<T> Items { get; set; }
        public DBItem()
        {
            this.Items = new List<T>();
        }

        public void AddItem(T item) { Items.Add(item); }

    }
}
