using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Domain.Entities;

namespace TestsWeb.Models
{
    public class AnswerViewModel
    {
        public int AnswerId { get; set; }
        public string Title { get; set; }
        public Boolean IsTrue { get; set; }
        public int Question { get; set; }
        public List<AnswerQuestionQuizUser> AnswerQuestionQuizUsers { get; set; }
    }
}
