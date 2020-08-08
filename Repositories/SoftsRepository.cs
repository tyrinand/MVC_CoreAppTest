using System.Collections.Generic;
using System.Linq;
using SaleSoft.Models.EF;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SaleSoft.Repositories
{
    public interface ISoftsRepository
    {
        List<Soft> GetSofts();
        // void Create(Sale sale);
        // void Delete(int id);
        //Sale Get(int id);
        //  void Update(Sale sale);
    }
    public class SoftsRepository : ISoftsRepository
    {
        private IdentityContext _context;
        public SoftsRepository(IdentityContext context)
        {
            _context = context;
        }

        public List<Soft> GetSofts()
        {
            return _context.Softs.ToList();
        }
    }
}
