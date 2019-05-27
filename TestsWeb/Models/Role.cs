using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Domain.Entities;

namespace TestsWeb.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Title { get; set; }
        public virtual List<RoleUser> RoleUser { get; set; }
    }
}
