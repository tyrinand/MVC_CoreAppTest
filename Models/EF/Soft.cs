using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleSoft.Models.EF
{
    public class Soft
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Des { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
