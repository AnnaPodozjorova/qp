using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class QuestionQuiz
    {
        public int QuestionQuizId { get; set; }
        public int QuestionsId { get; set; }
        public virtual Question Question { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
