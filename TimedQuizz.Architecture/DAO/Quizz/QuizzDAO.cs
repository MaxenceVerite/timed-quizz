using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;
using TimedQuizz.Domain.Models.Quizz;

namespace TimedQuizz.Architecture.DAO.Quizz
{
    public class QuizzDAO : GuidEntity
    {

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description{ get; set; }

        public int Difficulty { get; set; }

        [Range(0,5)]
        public float Rating { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        // Navigation 

        public virtual ICollection<Question> Questions { get; set; }

      

    }
}
