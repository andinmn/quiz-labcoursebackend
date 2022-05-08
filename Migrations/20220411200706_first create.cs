﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace quizapp_backend.Migrations
{
    public partial class firstcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Option4 = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    correctAnswer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
