using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Persistence.Configurations
{
    public class AnswerQuestionQuizUserConfiguration : IEntityTypeConfiguration<AnswerQuestionQuizUser>
    {
        public void Configure(EntityTypeBuilder<AnswerQuestionQuizUser> builder)
        {
            builder.HasKey(e => e.AnswerQuestionQuizUserId);
            builder.Property(u => u.AnswerQuestionQuizUserId).ValueGeneratedOnAdd();
        }
    }
}
