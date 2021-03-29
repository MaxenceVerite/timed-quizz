using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;
using TimedQuizz.Domain.Models.Quizz;

namespace TimedQuizz.Architecture.DAO.Quizz
{
    public class QuestionDAO : IntEntity
    {
        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        public  int Difficulty{ get; set; }

        [Range(0,120)]
        public int AllowedTime { get; set; }

        [StringLength(20)]
        public string QuestionType { get; set; }


        public virtual ICollection<AnswerDAO> Answers { get; set; }
    }
}
