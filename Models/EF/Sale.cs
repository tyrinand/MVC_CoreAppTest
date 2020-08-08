using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleSoft.Models.EF
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public int ClientId { get; set; }
        public int SoftId { get; set; }
        public int ShopId { get; set; }
        public int DiscountId { get; set; }

        public virtual Client Clinet { get; set; }
        public virtual Soft Soft { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual Discount Discount { get; set; }

        [NotMapped]
        public decimal Сost => (Count * Soft.Price) * (100.0M - Discount.Value) /100;
    }
}
