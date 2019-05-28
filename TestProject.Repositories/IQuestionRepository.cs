using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Repositories
{
    public interface IQuestionRepository : IRepository<Question>
    {
        Question GetQuestionByID(int id);
        List<Question> GetQuestionByQuiz(Question q);
    }
}
