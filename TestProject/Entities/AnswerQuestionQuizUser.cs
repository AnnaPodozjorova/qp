using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class AnswerQuestionQuizUser
    {
        public int AnswerQuestionQuizUserId { get; set; }
        public int QuizUserId { get; set; }
        public virtual QuizUser QuizUser { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public int AnswerId { get; set; }
        public virtual Answer Answer { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}
