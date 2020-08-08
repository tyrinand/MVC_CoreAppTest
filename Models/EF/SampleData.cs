using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleSoft.Models;
using CustomIdentityApp.Models;

namespace SaleSoft.Models.EF
{
    public static class SampleData
    {
        public static void Initialize(IdentityContext context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client { Id = 1, FullName = "Tom", Mark = 1 },
                    new Client { Id = 2, FullName = "Alice", Mark = 2 }
                );
                context.SaveChanges();
            }
            if (!context.Discounts.Any())
            {
                context.Discounts.AddRange(
                   new Discount { Id = 1, Value = 2.0M, Description = "Выходной день" },
                   new Discount { Id = 2, Value = 5.0M, Description = "Праздничный день" }
                );
                context.SaveChanges();
            }
            if (!context.Shops.Any())
            {
                context.Shops.AddRange(
                   new Shop { Id = 1, Name = "Ozon" },
                   new Shop { Id = 2, Name = "Беру" }
                );
                context.SaveChanges();
            }
            if (!context.Softs.Any())
            {
                context.Softs.AddRange(
                 new Soft { Id = 1, Name = "Word", Des = "Текстовый редактор", Price = 10000.0M, Count = 100 },
                 new Soft { Id = 2, Name = "Adode PhotoShop 10", Des = "Графический редактор", Price = 10000.0M, Count = 100 }
               );
                context.SaveChanges();
            }
            if (!context.Sales.Any())
            {
                context.Sales.AddRange(
                    new Sale { Id = 1, Count = 1, Date = DateTime.Now, ClientId = 1, DiscountId = 1, ShopId = 1, SoftId = 1 },
                    new Sale { Id = 2, Count = 1, Date = DateTime.Now, ClientId = 2, DiscountId = 2, ShopId = 2, SoftId = 2 }
                    );
                context.SaveChanges();
            }
        }
    }
}
