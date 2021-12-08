using Modeling_and_Project_Software;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProjectPD_34
{
    class DB
    {
        public IDBItem<Emploee> DbEmploee { get; set; }

        public DB()
        {
            this.DbEmploee = new DBItem<Emploee>();
            InitEmploee();
        }

        private void InitEmploee()
        {
            Emploee emploee1 = new Emploee("Bohdan", "Kolav", 23);
            DbEmploee.AddItem(emploee1);

            Emploee emploee2 = new Emploee("Andrey", "Pob", 18);
            DbEmploee.AddItem(emploee2);
        }
    }
}
