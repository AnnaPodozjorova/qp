﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Repositories
{
    public interface IQuizRepository : IRepository<Quiz>
    {
        Quiz GetQuizByID(int id);
    }
}