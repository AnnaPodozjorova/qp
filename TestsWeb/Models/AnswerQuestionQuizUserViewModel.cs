using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestsWeb.Models
{
    public class AnswerQuestionQuizUserViewModel
    {
        public int AnswerQuestionQuizUserId { get; set; }
        public int QuizUserId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}
