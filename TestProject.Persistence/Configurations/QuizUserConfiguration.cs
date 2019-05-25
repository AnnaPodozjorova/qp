using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Domain.Entities;

namespace TestProject.Persistence.Configurations
{
    public class QuizUserConfiguration : IEntityTypeConfiguration<QuizUser>
    {
        public void Configure(EntityTypeBuilder<QuizUser> builder)
        {
            builder.HasKey(e => e.QuizUserId);
            builder.Property(u => u.QuizUserId).ValueGeneratedOnAdd();
        }
    }
}
