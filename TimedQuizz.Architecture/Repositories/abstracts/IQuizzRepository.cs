using System;
using System.Collections.Generic;
using System.Text;

namespace TimedQuizz.Architecture.Repositories
{
    public interface IQuizzRepository : IRepository<Domain.Models.Quizz.Quizz, Guid>
    {
       
    }
}
