using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;

namespace TimedQuizz.Domain.Models.Quizz
{
    public class Quizz: GuidEntity
    {
        #region Props

        

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        private DifficultyE _difficulty;

        public DifficultyE Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; }
        }

        private float _rating;

        public float Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }




        private List<Question> _questions;

        public List<Question> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        #endregion


        public Quizz(Guid id, string title, string description, float rating, string category)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Rating = rating;
            this.Category = category;

        }

        public Quizz(Guid id, string title, string description, float rating, string category, List<Question> questions) : this(id, title, description, rating, category)
        {
            this.Questions = questions;
        }

        public Quizz(Guid id, string title, string description, DifficultyE difficulty, float rating, string category,  List<Question> questions) : this(id, title, description, rating, category)
        {
            this.Questions = questions;
            this.Difficulty = difficulty;
        }





        public Quizz AddQuestion(string title, int allowedTime, List<Answer> answers)
        {
            this.Questions.Add(
                new Question(title, allowedTime, answers)
                );

            return this;
        }


        public Quizz RemoveQuestion(int id)
        {
           if(this.Questions.RemoveAll(c => c.Id == id) == 0)
            {
                throw new KeyNotFoundException("The specified id was not found");
            }

            return this;
                
        }
    }
}
