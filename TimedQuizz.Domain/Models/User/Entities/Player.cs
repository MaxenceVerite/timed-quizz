using System;
using System.Collections.Generic;
using System.Text;
using TimedQuizz.Domain.Models.Abstracts;

namespace TimedQuizz.Domain.Models.User
{
    public class Player : GuidEntity
    {
        #region Props
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        #endregion

        public Player(string username)
        {
            this.Username = username;
        }

        public Player(Guid id, string username): this(username)
        {
            this.Id = id;
        }
    }
}
