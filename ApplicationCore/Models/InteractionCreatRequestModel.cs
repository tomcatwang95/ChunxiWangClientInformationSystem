﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class InteractionCreatRequestModel
    {
        public int ClientId { get; set; }
        public int EmpId { get; set; }
        public char IntType { get; set; }
        public DateTime IntDate { get; set; }
        public string Remarks { get; set; }
    }
}
