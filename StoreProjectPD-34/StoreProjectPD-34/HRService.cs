using Modeling_and_Project_Software;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProjectPD_34
{
    class HRService
    {
        private readonly DB _dB;

        public HRService(DB dB)
        {
            _dB = dB;
        }

        public void CreateHR(HR hr)
        {
            _dB.DbHrs.AddItem(hr);
        }
    }
}
