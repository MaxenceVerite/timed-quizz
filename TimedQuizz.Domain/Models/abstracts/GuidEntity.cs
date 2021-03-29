using System;
using System.Collections.Generic;
using System.Text;

namespace TimedQuizz.Domain.Models.Abstracts
{
    public abstract class GuidEntity : IEntity<Guid>
    {

        protected GuidEntity()
        {
        }

        protected GuidEntity(Guid id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            GuidEntity objet = (GuidEntity)obj;


            if (ReferenceEquals(this, objet))
                return true;



            if (Id.Equals(default) || this.Id.Equals(default))
                return false;

            return Id.Equals(objet.Id);
        }

        public static bool operator ==(GuidEntity a, GuidEntity b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Id.Equals(b.Id);
        }

        public static bool operator !=(GuidEntity a, GuidEntity b)
        {
            return !(a.Id == b.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

    }
}
