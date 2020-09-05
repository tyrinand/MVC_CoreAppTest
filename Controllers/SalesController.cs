using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using SaleSoft.Models;
using SaleSoft.Models.EF;

namespace SaleSoft.Controllers
{
    public class SalesController : Controller
    {
        private readonly IdentityContext _context;

        public SalesController(IdentityContext con)
        {
            _context = con;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 1;
            int count = _context.Sales.Count();
            var items = _context.Sales.Include(x => x.Shop).Include(x => x.Soft).Include(x => x.Clinet).Include(x => x.Discount).Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel<Sale> viewModel = new IndexViewModel<Sale>
            {
                PageViewModel = pageViewModel,
                List = items
            };

            return View(viewModel);
        }
    }
}
