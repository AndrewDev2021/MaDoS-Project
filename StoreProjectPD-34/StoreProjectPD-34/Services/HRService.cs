using StoreProjectPD_34.Database;
using StoreProjectPD_34.Models;
using System;
using System.Text;

namespace StoreProjectPD_34.Services
{
    class HRService : CommonService
    {
        private readonly DB _dB;

        public HRService(DB dB) : base(dB)
        {
            _dB = dB;
        }

        public void CreateHR(HR hr)
        {
            _dB.DbHrs.AddItem(hr);
        }
    }
}
