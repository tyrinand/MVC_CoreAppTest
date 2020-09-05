using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaleSoft.Models.EF;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CustomIdentityApp.Models
{
    public class IdentityContext : IdentityDbContext<User>
    {

        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Soft> Softs { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Shop> Shops { get; set; }

        public IdentityContext(DbContextOptions<IdentityContext> options)
                    : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
