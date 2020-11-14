using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using SaleSoft.Models;
using SaleSoft.Models.EF;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            int pageSize = 5;
            int count = _context.Sales.Count();
            var items = _context.Sales.Include(x => x.Shop).Include(x => x.Soft).Include(x => x.Clinet).Include(x => x.Discount).Skip((page - 1) * pageSize).Take(pageSize).OrderBy(x => x.Date).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel<Sale> viewModel = new IndexViewModel<Sale>
            {
                PageViewModel = pageViewModel,
                List = items
            };

            return View(viewModel);
        }

        [HttpPost]
        public bool Delete(int id)
        {
            var sale = _context.Sales.Where(s => s.Id == id).First();
            _context.Sales.Remove(sale);
            _context.SaveChanges();
            return true;
        }

        public IActionResult Create()
        {
            ViewBag.ShopId = _context.Shops.ToList();
            ViewBag.ClientId = _context.Clients.ToList();
            ViewBag.SoftId = _context.Softs.ToList();
            ViewBag.DiscountId = _context.Discounts.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult CreateSale(Sale sale)
        {
            sale.Soft = _context.Softs.Where(x => x.Id == sale.SoftId).First();
            sale.Discount = _context.Discounts.Where(x => x.Id == sale.DiscountId).First();


            _context.Sales.Add(sale);
            _context.SaveChanges();
            return RedirectToAction("Index", "Sales");
        }

        public IActionResult Update(int id)
        {
            ViewBag.ShopId = _context.Shops.ToList();
            ViewBag.ClientId = _context.Clients.ToList();
            ViewBag.SoftId = _context.Softs.ToList();
            ViewBag.DiscountId = _context.Discounts.ToList();

            var sale = _context.Sales.First(x => x.Id == id);
            return View(sale);
        }

        [HttpPost]
        public ActionResult Sale(Sale sale)
        {
            var model = _context.Sales.First(x => x.Id == sale.Id);

            model.Soft = _context.Softs.Where(x => x.Id == sale.SoftId).First();
            model.Discount = _context.Discounts.Where(x => x.Id == sale.DiscountId).First();

            model.ClientId = sale.ClientId;
            model.Count = sale.Count;
            model.Date = sale.Date;
            model.ShopId = sale.ShopId;

            _context.SaveChanges();

            return RedirectToAction("Index", "Sales");
        }
    }
}
