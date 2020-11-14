using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaleSoft.Models.EF
{
    public class Discount
    {
        public int Id { get; set; }
        public decimal Value { set; get; }

        public string Description { get; set; }

        [NotMapped]
        public string FullDescr => $"{Description} - {Value.ToString()} %";

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
