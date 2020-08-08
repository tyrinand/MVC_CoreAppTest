using System;
using System.Collections.Generic;

namespace SaleSoft.Models.EF
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public int Mark { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
