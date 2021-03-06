﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestProject.Persistence;

namespace TestProject.Persistence.Migrations
{
    [DbContext(typeof(TestProjectDBContext))]
    [Migration("20190525095424_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestProject.Domain.Entities.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsTrue");

                    b.Property<int>("QuestionID");

                    b.Property<string>("Title");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.AnswerQuestionQuizUser", b =>
                {
                    b.Property<int>("AnswerQuestionQuizUserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerId");

                    b.Property<DateTime>("Begin");

                    b.Property<DateTime>("End");

                    b.Property<int>("QuestionId");

                    b.Property<int>("QuizUserId");

                    b.HasKey("AnswerQuestionQuizUserId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("QuizUserId");

                    b.ToTable("AnswerQuestionQuizUsers");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionTime");

                    b.Property<string>("Title");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.QuestionQuiz", b =>
                {
                    b.Property<int>("QuizId");

                    b.Property<int>("QuestionsId");

                    b.Property<int>("QuestionQuizId");

                    b.HasKey("QuizId", "QuestionsId");

                    b.HasIndex("QuestionsId");

                    b.ToTable("Journalists");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.Property<int>("number");

                    b.HasKey("QuizId");

                    b.ToTable("Quizs");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.QuizUser", b =>
                {
                    b.Property<int>("QuizUserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Begin");

                    b.Property<DateTime>("Date");

                    b.Property<int>("QuizId");

                    b.Property<int>("UserId");

                    b.HasKey("QuizUserId");

                    b.HasIndex("QuizId");

                    b.HasIndex("UserId");

                    b.ToTable("QuizUsers");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.RoleUser", b =>
                {
                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.Property<int>("RoleUserId");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RoleUsers");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.Property<string>("telephone");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestProject.Domain.Entities.Answer", b =>
                {
                    b.HasOne("TestProject.Domain.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestProject.Domain.Entities.AnswerQuestionQuizUser", b =>
                {
                    b.HasOne("TestProject.Domain.Entities.Answer", "Answer")
                        .WithMany("AnswerQuestionQuizUsers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestProject.Domain.Entities.Question", "Question")
                        .WithMany("AsnwerQuestionQuizUsers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestProject.Domain.Entities.QuizUser", "QuizUser")
                        .WithMany("AnswerQuestionQuizUser")
                        .HasForeignKey("QuizUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestProject.Domain.Entities.QuestionQuiz", b =>
                {
                    b.HasOne("TestProject.Domain.Entities.Question", "Question")
                        .WithMany("QuestionQuiz")
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestProject.Domain.Entities.Quiz", "Quiz")
                        .WithMany("QuestionQuiz")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestProject.Domain.Entities.QuizUser", b =>
                {
                    b.HasOne("TestProject.Domain.Entities.Quiz", "Quiz")
                        .WithMany("QuizUser")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestProject.Domain.Entities.User", "User")
                        .WithMany("QuizUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestProject.Domain.Entities.RoleUser", b =>
                {
                    b.HasOne("TestProject.Domain.Entities.Role", "Role")
                        .WithMany("RoleUser")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestProject.Domain.Entities.User", "User")
                        .WithMany("RoleUser")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
