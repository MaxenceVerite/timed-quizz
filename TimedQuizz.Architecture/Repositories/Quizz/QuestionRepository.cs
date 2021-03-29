using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimedQuizz.Architecture.DAO.Quizz;
using TimedQuizz.Architecture.Repositories.abstracts;
using TimedQuizz.Domain.Models.Quizz;

namespace TimedQuizz.Architecture.Repositories.Quizz
{
    public class QuestionRepository : IQuestionRepository
    {

        private TimedQuizzContext _context { get; set; }
        public QuestionRepository(TimedQuizzContext context)
        {
            _context = context;
        }
        public Question Create(Question item)
        {
            _context.Questions.Add(new QuestionDAO()
            {
                Title = item.Title,
                Difficulty = (int)item.Difficulty,
                AllowedTime = item.AllowedTime,
                QuestionType = item.QuestionType.ToString()
            }
            );

            if (_context.SaveChanges() > 0) return item;
            else
            {
                return null;
            }
        }

        public bool Delete(long id)
        {
            QuestionDAO dao = _context.Questions.Find(id);

            if (dao == null) return false;

            _context.Questions.Remove(dao);


            if (_context.SaveChanges() > 0) return true;
            else
            {
                return false;
            }
        }

        public Question Get(long id)
        {
            QuestionDAO dao = _context.Questions.Include(q => q.Answers).FirstOrDefault(q => q.Id == id);
            
            if (dao == null) return null;

            List<Answer> answers = dao.Answers.Select(q => new Answer(q.Id, q.Value, q.IsCorrect)).ToList();
            ;

            Enum.TryParse(dao.QuestionType, out QuestionTypeE questionType);

            return new Question(dao.Id, dao.Title, dao.AllowedTime, (DifficultyE)dao.Difficulty, questionType, answers);

           
        }

        public IEnumerable<Question> List()
        {
            List<Question> questions = new List<Question>();
            foreach(QuestionDAO question in _context.Questions.Include(q => q.Answers))
            {
                Enum.TryParse(question.QuestionType, out QuestionTypeE questionType);
                questions.Add(
                    new Question(
                    question.Id, question.Title, question.AllowedTime, (DifficultyE)question.Difficulty, questionType,
                    question.Answers.Select(a => new Answer(a.Id, a.Value, a.IsCorrect)).ToList()
                    ));
            }

            return questions;
        }

        public Question Update(long id, Question item)
        {
            QuestionDAO dao = _context.Questions.Find(id);

            dao.Title = item.Title;
            dao.AllowedTime = item.AllowedTime;
            dao.Difficulty = (int)item.Difficulty;

            if (_context.SaveChanges() > 0) return item;

            else return null;
            
        }
    }
}
