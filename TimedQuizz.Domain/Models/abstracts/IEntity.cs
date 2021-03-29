using System;
using System.Collections.Generic;
using System.Text;

namespace TimedQuizz.Domain.Models.Abstracts
{
    public abstract class IEntity<T>
    {
        public T Id { get; protected set; }
    }
}
