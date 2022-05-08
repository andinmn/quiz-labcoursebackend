﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quizapp_backend.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        public string QuestionText { get; set; }
       
        [Column(TypeName = "nvarchar(250)")]
        public string? ImageName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option1 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option2 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option3 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option4  { get; set; }
        public int correctAnswer  { get; set; }


    }
}
