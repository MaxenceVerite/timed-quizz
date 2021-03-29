using System;
using System.Collections.Generic;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;

namespace TimedQuizz.Domain.Models.Quizz
{
    public class Answer : IntEntity
    {
        #region Props
       

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private bool _isCorrect;

        public bool IsCorrect
        {
            get { return _isCorrect; }
            set { _isCorrect = value; }
        }
        #endregion

        public Answer(string value, bool isCorrect)
        {
            this.Value = value;
            this.IsCorrect = isCorrect;
        }

        public Answer(long id, string value, bool isCorrect) : this(value, isCorrect)
        {
            this.Id = id;
        }


    }
}
