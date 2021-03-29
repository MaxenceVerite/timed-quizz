﻿using System;
using System.Collections.Generic;
using System.Text;
using TimedQuizz.Domain.Models.Quizz;

namespace TimedQuizz.Architecture.Repositories.abstracts
{
    public interface IGameRepository : IRepository<QuizzGame, Guid>
    {
    }
}
