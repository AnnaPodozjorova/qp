using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class Role
    {
        public Role()
        {
            RoleUser = new HashSet<RoleUser>();
        }
        public int RoleID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<RoleUser> RoleUser { get; set; }
    }
}
