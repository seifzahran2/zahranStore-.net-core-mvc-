using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using zahranStore.Models;

namespace zahranStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appContext;
        public HomeController(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        public IActionResult Index()
        {
            var cats = _appContext.Category.ToList();
            ViewBag.Product = _appContext.Product.ToList(); ;
            return View(cats);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Categories()
        {
            var cats = _appContext.Category.ToList(); 
            return View(cats);
        }

        public IActionResult Products(int id)
        {
            var products = _appContext.Product.Where(d=>d.CategoryId==id).ToList();
            return View(products);
        }
    }
}
