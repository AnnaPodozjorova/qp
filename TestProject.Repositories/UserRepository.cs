using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Domain.Entities;
using TestProject.Persistence;

namespace TestProject.Repositories
{
    public class UserRepository : IUserRepository
    {
        TestProjectDBContext context;

        public UserRepository()
        {
            context = new TestProjectDBContext();
        }

        public UserRepository(TestProjectDBContext context)
        {
            this.context = context;
        }

        public void Add(User entity)
        {
            context.Users.Add(entity);
        }

        public void Delete(User entity)
        {
            context.Users.Find(entity.UserId);
            context.Users.Remove(entity);
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
            GC.SuppressFinalize(this);
        }

        public void Edit(User entity)
        {
            var originalEntity = context.Users.Find(entity.UserId);
            context.Entry(originalEntity).CurrentValues.SetValues(entity);
        }

        public IEnumerable<User> FindBy(Func<User, bool> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IEnumerable<User> GetAll()
        {
            var users = context.Users;
            return users.AsQueryable<User>();
        }

        public User GetUserByID(int id)
        {
            return GetAll().Where(b => b.UserId == id).SingleOrDefault();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
