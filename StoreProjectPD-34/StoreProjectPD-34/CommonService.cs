﻿using System.Collections.Generic;
using System.Linq;

namespace StoreProjectPD_34
{
    class CommonService
    {
        private readonly DB _dB;
        public CommonService(DB dB)
        {
            _dB = dB;
        }

        public IEnumerable<EmploeeView> GetEmploees()
        {
            return _dB.DbEmploee.Items.AsEnumerable().Select(x=> new EmploeeView
            {
                Id = x.Id,
                Name = x.Name,
                SurName = x.SurName,
                Age = x.Age,
            });
        }

    }
}
