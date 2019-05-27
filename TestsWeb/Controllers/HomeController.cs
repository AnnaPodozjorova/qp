using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Persistence;
using TestProject.Repositories;
using TestsWeb.Models;

namespace TestsWeb.Controllers
{
    public class HomeController : Controller
    {
        IAnswerRepository ar;

        public IActionResult Index()
        {
           // List<Answer> l = ar.GetAll().ToList();
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
