using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestProject.Domain.Entities;
using TestProject.Repositories;
using TestsWeb.Models;
using Microsoft.AspNetCore.Authentication;
using TestProject.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using TestProject.Domain.Entities;
using TestProject.Repositories;

namespace TestsWeb.Controllers
{
    public class UserController : Controller
    {
        /*
        private TestProjectDBContext db;
        public UserController(TestProjectDBContext context)
        {
            db = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    Role role = new Role();
                    if (User.IsInRole("Admin"))
                    {
                        role = db.Roles.Find(model.RoleId);
                    }
                    else
                    {
                        role = await db.Roles.FirstOrDefaultAsync(r => r.Title == "User");
                    }

                    user = new User
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        Password = PasswordHashing.Create(model.Password),
                        RoleUser = role ?? null
                    };
                    db.Users.Add(user);
                    await db.SaveChangesAsync();

                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Login", "Account");
                }
                else
                    ModelState.AddModelError("", "User already exists");
            }


            return View(model);

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

            model.RoleName = new SelectList(db.Roles.OrderBy(o => o.Title).ToList(), "RoleId", "Title", 1);
            return View(model);
        }

        private async Task Authenticate(User user, RoleUser roleuser)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, roleuser.Role.Title)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(id));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.Include(u => u.RoleUser).
                    FirstOrDefaultAsync(u => u.Email == model.Email
                            && u.Password == PasswordHashing.Create(model.Password));
                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Incorrect login or password");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
        */
    }
}