using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Domain.Entities;

namespace TestsWeb.Models
{
    public class QuizViewModel
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public List<QuestionQuiz> QuestionQuiz { get; set; }
        public List<QuizUser> QuizUser { get; set; }
    }
}
