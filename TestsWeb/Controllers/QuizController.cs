using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Domain.Entities;
using TestProject.Persistence;
using TestProject.Repositories;

namespace TestsWeb.Controllers
{
    public class QuizController : Controller
    {
        IQuizRepository r;
        IQuestionRepository q;
        IAnswerRepository a;
        TestProjectDBContext context;

        public QuizController(IQuizRepository ar, IQuestionRepository ad, IAnswerRepository aa)
        {
            r = ar;
            q = ad;
            a = aa;

            context = new TestProjectDBContext();
        }

        public IActionResult Index()
        {
            List<Quiz> list = r.GetAll().ToList();
            return View(list);
        }

        [HttpPost]
        public IActionResult Edit()
        {
            int id = int.Parse(Request.Form["id"]);
            string title = Request.Form["Title"];
            string number = Request.Form["Questions"];
            string[] sep = number.Split(";");
            int[] nums = new int[sep.Length];
            for (int i = 0; i < sep.Length; i++)
            {
                nums[i] = int.Parse(sep[i]);
            }

            Quiz quiz = new Quiz() { number = sep.Length, QuizId = id, Title = title };
            List<QuestionQuiz> questQuiz = new List<QuestionQuiz>();
            foreach (QuestionQuiz q in context.Journalists)
                foreach (int idd in nums)
                    if (q.QuestionsId == idd && q.QuizId == id) {
                        context.Journalists.Remove(q);
                    }
            foreach (int n in nums)
            {
                questQuiz.Add(new QuestionQuiz { QuestionsId = n, QuizId = id, QuestionQuizId = n+100 });
            }
            context.Journalists.AddRange(questQuiz);
            r.Edit(quiz);
            r.Save();
            return View();
        }

        [HttpPost]
        public IActionResult Edit_Question()
        {
            int id = int.Parse(Request.Form["id"]);
            string title = Request.Form["Title"];
            string number = Request.Form["Answers"];
            Question quest = new Question() { Title = title, QuestionTime = int.Parse(number), QuestionId = id };
            q.Edit(quest);
            q.Save();
            return View();
        }

        [HttpPost]
        public IActionResult Edit_Answer()
        {
            int id = int.Parse(Request.Form["id"]);
            string title = Request.Form["Title"];
            string number = Request.Form["True"];
            string question = Request.Form["QuestionId"];
            Answer answ = new Answer() { Title = title, IsTrue = Boolean.Parse(number), QuestionID = int.Parse(question) };
            a.Edit(answ);
            a.Save();
            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {
            int id = int.Parse(Request.Form["id"]);
            string title = Request.Form["Title"];
            string number = Request.Form["Questions"];
            string[] sep = number.Split(";");
            int[] nums = new int[sep.Length];
            for (int i = 0; i < sep.Length; i++)
            {
                nums[i] = int.Parse(sep[i]);
            }

            Quiz quiz = new Quiz() { number = sep.Length, QuizId = id, Title = title };
            List<QuestionQuiz> questQuiz = new List<QuestionQuiz>();
            foreach (QuestionQuiz q in context.Journalists)
                foreach (int idd in nums)
                    if (q.QuestionsId == idd && q.QuizId == id)
                    {
                        context.Journalists.Remove(q);
                    }
            foreach (int n in nums)
            {
                questQuiz.Add(new QuestionQuiz { QuestionsId = n, QuizId = id, QuestionQuizId = n + 100 });
            }
            context.Journalists.AddRange(questQuiz);
            r.Add(quiz);
            r.Save();
            return View();
        }

        [HttpPost]
        public IActionResult Add_Question()
        {
            int id = int.Parse(Request.Form["id"]);
            string title = Request.Form["Title"];
            string number = Request.Form["Answers"];
            Question quest = new Question() { Title = title, QuestionTime = int.Parse(number), QuestionId = id };
            q.Add(quest);
            q.Save();
            return View();
        }

        [HttpPost]
        public IActionResult Add_Answer()
        {
            string title = Request.Form["Title"];
            string number = Request.Form["True"];
            string question = Request.Form["QuestionId"];
            Answer answ = new Answer() { Title = title, IsTrue = Boolean.Parse(number), QuestionID = int.Parse(question) };
            a.Add(answ);
            a.Save();
            return View();
        }
    }
}