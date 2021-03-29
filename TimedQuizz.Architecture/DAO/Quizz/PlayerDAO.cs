using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;

namespace TimedQuizz.Architecture.DAO.Quizz
{
    public class PlayerDAO : GuidEntity
    {
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
    }
}
