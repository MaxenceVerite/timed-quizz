using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimedQuizz.Architecture.DAO.Quizz;

namespace TimedQuizz.Architecture
{
    public class TimedQuizzContext : DbContext
    {
        public DbSet<QuizzDAO> Quizzes { get; set; }
        public DbSet<QuestionDAO> Questions { get; set; }

        public DbSet<AnswerDAO> Answers { get; set; }

        public DbSet<PlayerDAO> Players { get; set; }

      
        /// <summary>
        /// Player 1 - 1 Quizz
        /// </summary>
        public DbSet<GameDAO> Games {get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuizzDAO>().HasKey(q => q.Id);
            modelBuilder.Entity<QuestionDAO>().HasKey(q => q.Id); 
            modelBuilder.Entity<AnswerDAO>().HasKey(q => q.Id);
            modelBuilder.Entity<PlayerDAO>().HasKey(q => q.Id);
            modelBuilder.Entity<GameDAO>().HasKey(q => q.Id);
        }
    }
}
