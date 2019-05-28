using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestProject.Domain.Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Title { get; set; }
        public Boolean IsTrue { get; set; }
        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }
        public virtual ICollection<AnswerQuestionQuizUser> AnswerQuestionQuizUsers { get; } = new List<AnswerQuestionQuizUser>();
    }
}
