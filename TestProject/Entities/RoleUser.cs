﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class RoleUser
    {
        public int RoleUserId { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
