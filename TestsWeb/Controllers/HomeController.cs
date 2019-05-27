using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Domain.Entities;
using TestProject.Persistence;
using TestProject.Repositories;
using TestsWeb.Models;

namespace TestsWeb.Controllers
{
    public class HomeController : Controller
    {
        IQuizRepository r;

        public HomeController(IQuizRepository ar)
        {
            r = ar;
        }

        public IActionResult Index()
        {
            List<Quiz> list = r.GetAll().ToList();
            return View(list);
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
