using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class QuizUser
    {
        public QuizUser()
        {
            AnswerQuestionQuizUser = new HashSet<AnswerQuestionQuizUser>();
        }
        public int QuizUserId { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
        public DateTime Begin { get; set; }
        public virtual ICollection<AnswerQuestionQuizUser> AnswerQuestionQuizUser { get; set; }
    }
}
