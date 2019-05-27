using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Domain.Entities;

namespace TestsWeb.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public int QuestionTime { get; set; }
        public List<QuestionQuiz> QuestionQuiz { get; set; }
        public List<Answer> Answers { get; set; }
        public List<AnswerQuestionQuizUser> AnswerQuestionQuizUsers { get; set; }
    }
}
