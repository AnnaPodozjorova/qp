﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Repositories
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetRoleByID(int id);
    }
}