﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.BL
{
    class subject
    {
        public string code;
        public int creditHours;
        public string subjectType;
        public int subjectFee; 
        public subject()
        {

        }
        public subject(string code,  string subjectType, int creditHours, int subjectFee)
        {
            this.code = code;
            this.subjectType = subjectType;
            this.creditHours = creditHours;
            this.subjectFee = subjectFee;
        }
    }
}
