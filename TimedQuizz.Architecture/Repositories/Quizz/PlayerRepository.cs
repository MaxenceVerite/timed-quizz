using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimedQuizz.Architecture.DAO.Quizz;
using TimedQuizz.Architecture.Repositories.abstracts;
using TimedQuizz.Domain.Models.User;

namespace TimedQuizz.Architecture.Repositories.Quizz
{
    public class PlayerRepository : IPlayerRepository
    {


        private TimedQuizzContext _context { get; set; }
        public PlayerRepository(TimedQuizzContext context)
        {
            _context = context;
        }

        public Player Create(Player item)
        {
            PlayerDAO dao = new PlayerDAO()
            {
                Username = item.Username
            };

            _context.Players.Add(dao);

            if (_context.SaveChanges() > 0) return item;
            else
            {
                return null;
            }
        }

        public bool Delete(Guid id)
        {
            PlayerDAO itemToDelete = _context.Players.Find(id);

            if (itemToDelete == null) return false;

            _context.Players.Remove(itemToDelete);

            if (_context.SaveChanges() > 0) return true;
            else
            {
                return false;
            }

        }

        public Player Get(Guid id)
        {
            PlayerDAO dao = _context.Players.Find(id);

            return new Player(dao.Id, dao.Username);
        }

        public IEnumerable<Player> List()
        {

            IEnumerable<Player> items = _context.Players.Select(
                dao => new Player(dao.Id, dao.Username)

                );

            return items;
        }

        public Player Update(Guid id, Player item)
        {
           PlayerDAO dao = _context.Players.Find(id);

           dao.Username = item.Username;

            return new Player(dao.Id, dao.Username);
        }
    }
}
