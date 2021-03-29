using System;
using System.Collections.Generic;
using System.Linq;
using TimedQuizz.Domain.Models.Abstracts;

namespace TimedQuizz.Domain.Models.Quizz
{
    public class Question : IntEntity
    {
        #region Props
       

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private DifficultyE _difficulty;

        public DifficultyE Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; }
        }


        private List<Answer> _answers;

        public List<Answer> Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }


        private int _allowedTime;

        public int AllowedTime
        {
            get { return _allowedTime; }
            set { _allowedTime = value; }
        }

        private QuestionTypeE _questionType;

        public QuestionTypeE QuestionType
        {
            get { return _questionType; }
            private set { 
                if(_questionType != QuestionTypeE.Unset)
                {
                    throw new MemberAccessException("You cannot set question type when it is already calculated");
                }
                _questionType = value;
            
            }
        }


        #endregion


        public Question(string title, int allowedTime, DifficultyE difficulty, List<Answer> answers)
        {
            
            this.Title = title;
            this.AllowedTime = allowedTime;
            this.Difficulty = difficulty;
            this.Answers = answers;
            this.QuestionType = this.Answers.Where(c => c.IsCorrect).Count() > 1 ? QuestionTypeE.MultipleChoices : QuestionTypeE.SingleChoice;
        }

        public Question(long id, string title, int allowedTime, DifficultyE difficulty, List<Answer> answers) : this(title,allowedTime, difficulty,answers)
        {
            this.Id = id;
        
        }

        public Question(long id, string title, int allowedTime, DifficultyE difficulty, QuestionTypeE questionType, List<Answer> answers) : this(id,title, allowedTime, difficulty, answers)
        {
            this.QuestionType = questionType;

        }

    }
}
