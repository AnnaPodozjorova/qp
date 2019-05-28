using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class Question
    {
        public Question()
        {
            QuestionQuiz = new HashSet<QuestionQuiz>();
            Answers = new HashSet<Answer>();
            AnswerQuestionQuizUsers = new HashSet<AnswerQuestionQuizUser>();
        }

        public int QuestionId { get; set; }
        public string Title { get; set; }
        public int QuestionTime { get; set; }
        public virtual ICollection<QuestionQuiz> QuestionQuiz { get; } = new List<QuestionQuiz>();
        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
        public virtual ICollection<AnswerQuestionQuizUser> AnswerQuestionQuizUsers { get; } = new List<AnswerQuestionQuizUser>();
    }
}
