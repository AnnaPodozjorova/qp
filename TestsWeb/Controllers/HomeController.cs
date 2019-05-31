using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Index(string sortOrder, string searchString)
        {   var e = r.GetAll();
            IEnumerable<Quiz> quizzes = r.GetAll();
            ViewBag.Quizs = quizzes;
            if (!String.IsNullOrEmpty(searchString))
            {
                ViewBag.Quizs = quizzes.Where(s => s.Title.ToLower().Contains(searchString.ToLower()));
            }

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            switch (sortOrder)
            {
                case "name_desc":
                    ViewBag.Quizs = quizzes.OrderByDescending(s => s.Title);
                    break;
                default:
                    ViewBag.Quizs = quizzes;
                    break;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Test(int id)
        {
            ViewBag.QuizId = id;
            ViewBag.Questions =r.GetQuestionsByQuizId(id);
            return View();
        }

        [HttpPost]
        public IActionResult Results(int id)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(r.GetQuizByID(id));
        }

        [HttpPost]
        public ActionResult Edit(Quiz q)
        {
            r.Edit(q);
            r.Save();
            return View();
        }

        [HttpPost]
        public ViewResult Submit(IFormCollection iformcollection)
        {
            int score = 0;
            string[] qIds = iformcollection["questionId"];
            foreach(var questionId in qIds)
            {
                int answerIdCorrect = r.GetQuestionByID(int.Parse(questionId)).Answers.
                    Where(a => a.IsTrue == true).FirstOrDefault().QuestionID;
                if(answerIdCorrect == int.Parse(iformcollection["question_" + questionId]))
                {
                    score++;
                }
            }
            ViewBag.score = score;
            return View("Home/Submit");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
