using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Domain.Entities;
using TestProject.Persistence;

namespace TestProject.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        TestProjectDBContext context;

        public RoleRepository()
        {
            context = new TestProjectDBContext();
        }

        public RoleRepository(TestProjectDBContext context)
        {
            this.context = context;
        }

        public void Add(Role entity)
        {
            context.Roles.Add(entity);
        }

        public void Delete(Role entity)
        {
            context.Roles.Find(entity.RoleID);
            context.Roles.Remove(entity);
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

        public void Edit(Role entity)
        {
            var originalEntity = context.Roles.Find(entity.RoleID);
            context.Entry(originalEntity).CurrentValues.SetValues(entity);
        }

        public IEnumerable<Role> FindBy(Func<Role, bool> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IEnumerable<Role> GetAll()
        {
            var roles = context.Roles;
            return roles.AsQueryable<Role>();
        }

        public Role GetRoleByID(int id)
        {
            return GetAll().Where(b => b.RoleID == id).SingleOrDefault();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
