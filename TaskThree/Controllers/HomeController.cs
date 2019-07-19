using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskThree.BLL.Interfaces;
using TaskThree.Models;

namespace TaskThree.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantService _service;

        public HomeController(IRestaurantService service)
        {
            _service = service;
        }
        public IActionResult Index(string postalCode ="1234")
        {
            var restaurants = _service.GetByPostalCode(postalCode);
            return View(restaurants);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
