using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Domain.Entities;
using TestProject.Persistence;

namespace TestProject.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        TestProjectDBContext context;

        public QuizRepository()
        {
            context = new TestProjectDBContext();
        }

        public QuizRepository(TestProjectDBContext context)
        {
            this.context = context;
        }

        public void Add(Quiz entity)
        {
            context.Quizs.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Quiz entity)
        {
            context.Quizs.Find(entity.QuizId);
            context.Quizs.Remove(entity);
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

        public void Edit(Quiz entity)
        {
            var originalEntity = context.Quizs.Find(entity.QuizId);
            context.Entry(originalEntity).CurrentValues.SetValues(entity);
        }

        public IEnumerable<Quiz> FindBy(Func<Quiz, bool> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IEnumerable<Quiz> GetAll()
        {
            var allquiz = context.Quizs;
            return allquiz.AsQueryable<Quiz>();
        }

        public Quiz GetQuizByID(int id)
        {
            return GetAll().Where(b => b.QuizId == id).SingleOrDefault();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
