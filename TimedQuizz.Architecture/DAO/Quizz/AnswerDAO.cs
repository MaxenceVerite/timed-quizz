using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;

namespace TimedQuizz.Architecture.DAO.Quizz
{
    public class AnswerDAO : IntEntity
    {
        #region Props
        [Required]
        [StringLength(80)]
        public string Value { get; set; }

        [Required]
        public bool IsCorrect { get; set; }
        #endregion

        
       
    }
}
