using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaleSoft.Models;
using SaleSoft.Models.EF;

namespace SaleSoft.Controllers
{
    public class SoftsController : Controller
    {
        private readonly IdentityContext _context;

        public SoftsController(IdentityContext con)
        {
            _context = con;
        }
        public IActionResult Index(int page = 1)
        {
            int pageSize = 5;
            int count = _context.Softs.Count();
            var items = _context.Softs.Skip((page - 1) * pageSize).Take(pageSize).OrderBy(x =>x.Id).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel<Soft> viewModel = new IndexViewModel<Soft>
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
        public ActionResult CreateSoft(Soft soft)
        {
            _context.Softs.Add(soft);
            _context.SaveChanges();
            return RedirectToAction("Index", "Softs");
        }

        public IActionResult Update(int id)
        {
            var soft = _context.Softs.First(x => x.Id == id);
            return View(soft);
        }

        [HttpPost]
        public ActionResult UpdateSoft(Soft soft, string PriceStr)
        {
            var model = _context.Softs.First(x => x.Id == soft.Id);
            var value = PriceStr.Replace('.',',');

            model.Name = soft.Name;
            model.Des = soft.Des;
            model.Price = Convert.ToDecimal(value);
            model.Count = soft.Count;

            _context.SaveChanges();
            
            return RedirectToAction("Index", "Softs");
        }

        [HttpPost]
        public bool Delete(int id)
        {
            var soft = _context.Softs.Where(s => s.Id == id).First();
            _context.Softs.Remove(soft);
            _context.SaveChanges();
            return true;
        }

    }
}
