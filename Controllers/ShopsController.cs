using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleSoft.Models;
using SaleSoft.Models.EF;
using CustomIdentityApp.Models;

namespace SaleSoft.Controllers
{
    public class ShopsController : Controller
    {
        private readonly IdentityContext _context;

        public ShopsController(IdentityContext con)
        {
            _context = con;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 5;
            int count = _context.Shops.Count();
            var items = _context.Shops.Skip((page - 1) * pageSize).Take(pageSize).OrderBy(x => x.Id).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel<Shop> viewModel = new IndexViewModel<Shop>
            {
                PageViewModel = pageViewModel,
                List = items
            };

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateShop(Shop shop)
        {
            _context.Shops.Add(shop);
            _context.SaveChanges();
            return RedirectToAction("Index", "Shops");
        }

        [HttpPost]
        public bool Delete(int id)
        {
            var shop = _context.Shops.Where(s => s.Id == id).First();
            _context.Shops.Remove(shop);
            _context.SaveChanges();
            return true;
        }

        public IActionResult Update(int id)
        {
            var shop = _context.Shops.First(x => x.Id == id);
            return View(shop);
        }

        [HttpPost]
        public ActionResult UpdateShop(Shop shop)
        {
            var model = _context.Shops.First(x => x.Id == shop.Id);

            model.Name = shop.Name;
            _context.SaveChanges();

            return RedirectToAction("Index", "Shops");
        }
    }
}
