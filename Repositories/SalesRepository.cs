using System.Collections.Generic;
using System.Linq;
using SaleSoft.Models.EF;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SaleSoft.Repositories
{
    public interface ISalesRepository 
    {
       // void Create(Sale sale);
       // void Delete(int id);
      //  Sale Get(int id);
       List<Sale> GetSales();
      //  void Update(Sale sale);
    }
    public class SalesRepository : ISalesRepository
    {
        private readonly IdentityContext _context;
        public SalesRepository(IdentityContext dbContext)
        {
            _context = dbContext;
        }

        public List<Sale> GetSales()
        {
            return _context.Sales.Include(x => x.Clinet).Include(x => x.Soft).Include(x => x.Discount).Include(x => x.Shop).ToList();
        }
    }
}
