using System;
using System.Collections.Generic;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;
using TimedQuizz.Domain.Models.User;

namespace TimedQuizz.Domain.Models.Quizz
{
    public class QuizzGame : GuidEntity
    {

        #region Props


        private Player _player;

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        private Quizz _quizz;

        public Quizz Quizz
        {
            get { return _quizz; }
            set { _quizz = value; }
        }


        private DateTime _startTime;

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        private DateTime _endTime;

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        private double _score;

        public double Score
        {
            get { return _score; }
            set { _score = value; }
        }
        #endregion

        public QuizzGame(Quizz quizz, DateTime startTime, DateTime endTime, double score)
        {
            this.Quizz = quizz;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Score = score;
        }

        public QuizzGame(Guid id,Quizz quizz, DateTime startTime, DateTime endTime, double score) : this(quizz,startTime,endTime,score)
        {
            this.Id = id;
        }



    }
}
