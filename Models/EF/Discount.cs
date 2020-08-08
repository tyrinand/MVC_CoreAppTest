﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleSoft.Models.EF
{
    public class Discount
    {
        public int Id { get; set; }
        public decimal Value { set; get; }

        public string Description { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
