﻿using HMO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Common.DTO
{
    public class PersonalDetailesDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house_number { get; set; }
        public string telephon { get; set; }
        public string pelephon { get; set; }
        public int vaccination_number { get; set; }
        public DateTime start_ill { get; set; }
        public DateTime end_ill { get; set; }
        

    }
}
