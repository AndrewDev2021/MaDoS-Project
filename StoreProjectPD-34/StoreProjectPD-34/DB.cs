using Modeling_and_Project_Software;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProjectPD_34
{
    class DB
    {
        public IDBItem<Emploee> dbEmploee { get; set; }

        public DB()
        {
            this.dbEmploee = new DBItem<Emploee>();
            InitEmploee();
        }

        private void InitEmploee()
        {
            Emploee emploee1 = new Emploee("Bohdan", "Kolav", 23);
            dbEmploee.AddItem(emploee1);

            Emploee emploee2 = new Emploee("Andrey", "Pob", 18);
            dbEmploee.AddItem(emploee2);
        }
    }
}
