using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class Quiz
    {
        public Quiz()
        {
            QuestionQuiz = new HashSet<QuestionQuiz>();
            QuizUser = new HashSet<QuizUser>();
        }

        public int QuizId { get; set; }
        public string Title { get; set; }
        public int number { get; set; }
        public virtual ICollection<QuestionQuiz> QuestionQuiz { get; } = new List<QuestionQuiz>();
        public virtual ICollection<QuizUser> QuizUser { get; } = new List<QuizUser>();
    }
}
