using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimedQuizz.Architecture.Repositories.abstracts;
using TimedQuizz.Domain.Models.Quizz;

namespace TimedQuizz.Architecture.Repositories.Quizz
{
    public class GameRepository : IGameRepository
    {


        private TimedQuizzContext _context { get; set; }
        public GameRepository(TimedQuizzContext context)
        {
            _context = context;
        }

        public QuizzGame Create(QuizzGame item)
        {
           if(item == null)
            {
                throw new InvalidOperationException("QuizzGame item is null");
            }

            _context.Games.Add(new DAO.Quizz.GameDAO()
            {
                StartDate = item.StartTime,
                EndDate = item.EndTime,
                Score = item.Score
            });

            if(_context.SaveChanges() > 0)
               return item;
            else return null;
        }

        public bool Delete(Guid id)
        {
            DAO.Quizz.GameDAO item = _context.Games.Find(id);

            if (item == null) return false;

            _context.Games.Remove(item);

            if(_context.SaveChanges() > 0) return true;

            return false;
        }

        public QuizzGame Get(Guid id)
        {
            //DAO.Quizz.GameDAO item = _context.Games.Include(q => q.Quizzes).
                                             

            
        }

        public IEnumerable<QuizzGame> List()
        {
            return _context.Games.ToList();
        }

        public QuizzGame Update(Guid id, QuizzGame item)
        {
            throw new NotImplementedException();
        }
    }
}
