using System;
using System.Collections.Generic;
using System.Text;
using TimedQuizz.Architecture.DAO.Quizz;
using TimedQuizz.Domain.Models.Quizz;

namespace TimedQuizz.Architecture.Repositories
{
    public class QuizzRepository : IQuizzRepository
    {

        private TimedQuizzContext _context { get; set; }
        public QuizzRepository(TimedQuizzContext context)
        {
            _context = context;
        }

        public Domain.Models.Quizz.Quizz Create(Domain.Models.Quizz.Quizz item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Quizz.Quizz Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Models.Quizz.Quizz> List()
        {
            throw new NotImplementedException();
        }

        public Domain.Models.Quizz.Quizz Update(Guid id, Domain.Models.Quizz.Quizz item)
        {
            throw new NotImplementedException();
        }
    }
}
