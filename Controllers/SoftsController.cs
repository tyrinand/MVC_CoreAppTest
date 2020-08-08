using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleSoft.Repositories;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaleSoft.Models;

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
            int pageSize = 1;
            int count = _context.Softs.Count();
            var items = _context.Softs.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Softs = items
            };

            return View(viewModel);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            return View();
        }
    }
}
