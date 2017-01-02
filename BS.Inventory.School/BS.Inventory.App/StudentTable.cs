﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Inventory.App
{
    class StudentTable : Table
    {
        protected const string suffixID = "STD";
        public StudentTable(int iID, char iconString = '=') : base(iID, iconString) {
            this.iID = string.Concat(this.iID, suffixID);
        }


    }
}