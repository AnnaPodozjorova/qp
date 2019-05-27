using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Domain.Entities;
using TestProject.Persistence;

namespace TestProject.Repositories
{
    public class AnswersRepository : IAnswerRepository
    {
        TestProjectDBContext context;

        public AnswersRepository()
        {
            context = new TestProjectDBContext();
        }

        public AnswersRepository(TestProjectDBContext context)
        {
            this.context = context;
        }

        public Answer GetAnswerByID(int id)
        {
            return GetAll().Where(b => b.AnswerId == id).SingleOrDefault();
        }

        public List<Answer> GetAnswerByQuestion(int id)
        {
            return GetAll().Where(b => b.QuestionID == id).ToList();
        }

        public IEnumerable<Answer> GetAll()
        {
            var answers = context.Answers
                .Include(fa => fa.Question);
            return answers.AsQueryable<Answer>();
        }

        public IEnumerable<Answer> FindBy(Func<Answer, bool> predicate)
        {
            return GetAll().Where(predicate);
        }

        public void Add(Answer entity)
        {
            context.Answers.Add(entity);
        }

        public void Delete(Answer entity)
        {
            context.Answers.Find(entity.AnswerId);
            context.Answers.Remove(entity);
        }

        public void Edit(Answer entity)
        {
            var originalEntity = context.Answers.Find(entity.AnswerId);
            context.Entry(originalEntity).CurrentValues.SetValues(entity);
        }

        public void Save()
        {
            context.SaveChanges();
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
    }
}
