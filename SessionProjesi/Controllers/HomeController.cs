using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionProjesi.Models;

namespace SessionProjesi.Controllers
{
    public class HomeController : Controller
    {
         string SessionName = "_Name";
         string SessionAge = "_Age";
        public IActionResult Index()
        {
            HttpContext.Session.SetString(SessionName, "Jarvik");
            HttpContext.Session.SetInt32(SessionAge, 24);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);
            ViewData["Message"] = "Asp.Net Core !!!.";
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
