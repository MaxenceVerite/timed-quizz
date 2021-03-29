using System;
using System.Collections.Generic;
using System.Text;

namespace TimedQuizz.Architecture.Repositories
{
    public interface IRepository<T, E> where T : class
                                       where E: struct
                                      
    {

        T Create(T item);

        T Update(E id, T item);
        T Get(E id);

        bool Delete(E id);

        IEnumerable<T> List();


    }
}
