using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleSoft.Repositories;
using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SaleSoft.Controllers
{
    public class SalesController : Controller
    {
        private ISalesRepository _rep;

        public SalesController(ISalesRepository rep)
        {
            _rep = rep;
        }

        public IActionResult Index()
        {
            var sales = _rep.GetSales();
            return View(sales);
        }
    }
}
