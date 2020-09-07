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
    public class DiscountsController : Controller
    {
        private readonly IdentityContext _context;

        public DiscountsController(IdentityContext con)
        {
            _context = con;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 5;
            int count = _context.Discounts.Count();
            var items = _context.Discounts.Skip((page - 1) * pageSize).Take(pageSize).OrderBy(x => x.Id).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel<Discount> viewModel = new IndexViewModel<Discount>
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
        public ActionResult CreateDiscount(Discount discount, string DisVal)
        {
            var value = DisVal.Replace('.', ',');
            discount.Value = Convert.ToDecimal(value);

            _context.Discounts.Add(discount);
            _context.SaveChanges();
            return RedirectToAction("Index", "Discounts");
        }

        [HttpPost]
        public bool Delete(int id)
        {
            var discount = _context.Discounts.Where(s => s.Id == id).First();
            _context.Discounts.Remove(discount);
            _context.SaveChanges();
            return true;
        }

        public IActionResult Update(int id)
        {
            var discount = _context.Discounts.First(x => x.Id == id);
            return View(discount);
        }

        [HttpPost]
        public ActionResult UpdateDiscount(Discount discount, string DisVal)
        {
            var value = DisVal.Replace('.', ',');
            discount.Value = Convert.ToDecimal(value);

            var model = _context.Discounts.First(x => x.Id == discount.Id);

            model.Description = discount.Description;
            model.Value = discount.Value;

            _context.SaveChanges();

            return RedirectToAction("Index", "Discounts");
        }
    }
}
