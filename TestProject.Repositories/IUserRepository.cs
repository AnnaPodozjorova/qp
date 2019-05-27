using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByID(int id);
    }
}
