﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GLC.Cores.Models
{
    public class StudentQuizeQuestionBank
    {
        [Required]
        [ForeignKey("Quize")]
        public int QuizeId { get; set; }
        public  Quize Quize { get; set; }
        [Required]
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public  QuestionBank Question { get; set; }
        [Required]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get;set; }
    }
}