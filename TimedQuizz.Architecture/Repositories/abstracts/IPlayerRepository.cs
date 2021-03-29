using System;
using System.Collections.Generic;
using System.Text;
using TimedQuizz.Domain.Models.User;

namespace TimedQuizz.Architecture.Repositories.abstracts
{
    public interface IPlayerRepository : IRepository<Player, Guid>
    {
    }
}
