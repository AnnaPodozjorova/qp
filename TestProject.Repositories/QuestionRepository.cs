using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Domain.Entities;
using TestProject.Persistence;

namespace TestProject.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        TestProjectDBContext context;

        public QuestionRepository()
        {
            context = new TestProjectDBContext();
        }

        public QuestionRepository(TestProjectDBContext context)
        {
            this.context = context;
        }

        public void Add(Question entity)
        {
            context.Questions.Add(entity);
        }

        public void Delete(Question entity)
        {
            context.Questions.Find(entity.QuestionId);
            context.Questions.Remove(entity);
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

        public void Edit(Question entity)
        {
            var originalEntity = context.Questions.Find(entity.QuestionId);
            context.Entry(originalEntity).CurrentValues.SetValues(entity);
        }

        public IEnumerable<Question> FindBy(Func<Question, bool> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IEnumerable<Question> GetAll()
        {
            var questions = context.Questions;
            return questions.AsQueryable<Question>();
        }

        public Question GetQuestionByID(int id)
        {
            return GetAll().Where(b => b.QuestionId == id).SingleOrDefault();
        }

        public List<Question> GetQuestionByQuiz(Question q)
        {
            return GetAll().Where(b => b.QuestionQuiz == q).ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
