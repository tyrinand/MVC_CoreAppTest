using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using SaleSoft.Models;
using SaleSoft.Models.EF;

namespace SaleSoft.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IdentityContext _context;

        public ClientsController(IdentityContext con)
        {
            _context = con;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 5;
            int count = _context.Clients.Count();
            var items = _context.Clients.Skip((page - 1) * pageSize).Take(pageSize).OrderBy(x => x.Id).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel<Client> viewModel = new IndexViewModel<Client>
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
        public ActionResult CreateClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return RedirectToAction("Index", "Clients");
        }

        [HttpPost]
        public bool Delete(int id)
        {
            var client = _context.Clients.Where(s => s.Id == id).First();
            _context.Clients.Remove(client);
            _context.SaveChanges();
            return true;
        }

        public IActionResult Update(int id)
        {
            var soft = _context.Clients.First(x => x.Id == id);
            return View(soft);
        }

        [HttpPost]
        public ActionResult UpdateClient(Client client)
        {
            var model = _context.Clients.First(x => x.Id == client.Id);

            model.FullName = client.FullName;
            model.Mark = client.Mark;
            _context.SaveChanges();

            return RedirectToAction("Index", "Clients");
        }
    }
}
