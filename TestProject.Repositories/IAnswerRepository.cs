using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Repositories
{
    public interface IAnswerRepository : IRepository<Answer>
    {
        Answer GetAnswerByID(int id);
        List<Answer> GetAnswerByQuestion(int id);
    }
}
