using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Repositories
{
    public interface ITestRepository : IRepository<Answer>
    {
        Answer GetAnswerByID(int id);
        Answer GetAnswerByQuestion(int id);
    }
}
