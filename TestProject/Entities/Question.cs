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
            AsnwerQuestionQuizUsers = new HashSet<AnswerQuestionQuizUser>();
        }

        public int QuestionId { get; set; }
        public string Title { get; set; }
        public int QuestionTime { get; set; }
        public virtual ICollection<QuestionQuiz> QuestionQuiz { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<AnswerQuestionQuizUser> AsnwerQuestionQuizUsers { get; set; }
    }
}
