using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Domain.Entities;

namespace TestsWeb.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public virtual List<RoleUser> RoleUser { get; set; }
        public virtual List<QuizUser> QuizUser { get; set; }
    }
}
