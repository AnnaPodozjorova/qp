using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class User
    {
        public User()
        {
            RoleUser = new HashSet<RoleUser>();
            QuizUser = new HashSet<QuizUser>();
        }
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string telephone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<RoleUser> RoleUser { get; set; }
        public virtual ICollection<QuizUser> QuizUser { get; set; }
    }
}
