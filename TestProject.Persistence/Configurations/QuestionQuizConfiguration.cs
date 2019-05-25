using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Persistence.Configurations
{
    public class QuestionQuizConfiguration : IEntityTypeConfiguration<QuestionQuiz>
    {
        public void Configure(EntityTypeBuilder<QuestionQuiz> builder)
        {
            builder.HasKey(e => e.QuestionQuizId);
            builder.Property(u => u.QuestionQuizId).ValueGeneratedOnAdd();
        }
    }
}
