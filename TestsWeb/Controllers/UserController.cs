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
        private TestsProjectDBContext db;
        public UserController(TestsProjectDBContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            List<Quiz> list = r.GetAll().ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();

            model.RoleName = new SelectList(db.Roles.OrderBy(o => o.RoleName).ToList(), "RoleId", "RoleName", 1);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.Include(u => u.Role).
                    FirstOrDefaultAsync(u => u.Email == model.Email
                            && u.Password == PasswordHashing.HashPassword(model.Password));
                if (user != null)
                {
                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }

            return View(model);
        }
    }
}