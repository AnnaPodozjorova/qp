using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProject.Persistence.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    QuestionTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Quizs",
                columns: table => new
                {
                    QuizId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizs", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    telephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    IsTrue = table.Column<bool>(nullable: false),
                    QuestionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Journalists",
                columns: table => new
                {
                    QuestionsId = table.Column<int>(nullable: false),
                    QuizId = table.Column<int>(nullable: false),
                    QuestionQuizId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journalists", x => new { x.QuizId, x.QuestionsId });
                    table.ForeignKey(
                        name: "FK_Journalists_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Journalists_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizUsers",
                columns: table => new
                {
                    QuizUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuizId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Begin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizUsers", x => x.QuizUserId);
                    table.ForeignKey(
                        name: "FK_QuizUsers_Quizs_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizs",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUsers",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RoleUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUsers", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RoleUsers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnswerQuestionQuizUsers",
                columns: table => new
                {
                    AnswerQuestionQuizUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuizUserId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    AnswerId = table.Column<int>(nullable: false),
                    Begin = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerQuestionQuizUsers", x => x.AnswerQuestionQuizUserId);
                    table.ForeignKey(
                        name: "FK_AnswerQuestionQuizUsers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "AnswerId"
                       );
                    table.ForeignKey(
                        name: "FK_AnswerQuestionQuizUsers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId"
                       );
                    table.ForeignKey(
                        name: "FK_AnswerQuestionQuizUsers_QuizUsers_QuizUserId",
                        column: x => x.QuizUserId,
                        principalTable: "QuizUsers",
                        principalColumn: "QuizUserId"
                     );
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerQuestionQuizUsers_AnswerId",
                table: "AnswerQuestionQuizUsers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerQuestionQuizUsers_QuestionId",
                table: "AnswerQuestionQuizUsers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerQuestionQuizUsers_QuizUserId",
                table: "AnswerQuestionQuizUsers",
                column: "QuizUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionID",
                table: "Answers",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Journalists_QuestionsId",
                table: "Journalists",
                column: "QuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizUsers_QuizId",
                table: "QuizUsers",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizUsers_UserId",
                table: "QuizUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_UserId",
                table: "RoleUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerQuestionQuizUsers");

            migrationBuilder.DropTable(
                name: "Journalists");

            migrationBuilder.DropTable(
                name: "RoleUsers");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "QuizUsers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
