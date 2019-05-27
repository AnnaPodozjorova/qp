using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Domain.Entities;
using TestProject.Repositories;

namespace TestsWeb.Controllers
{
    public class QuizController : Controller
    {
        IQuizRepository r;

        public QuizController(IQuizRepository ar)
        {
            r = ar;
        }

        public IActionResult Index()
        {
            List<Quiz> list = r.GetAll().ToList();
            return View(list);
        }
    }
}