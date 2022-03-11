using System;
using System.Collections.Generic;

namespace Maverick.Books.Domain
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; protected set; }

        /// <summary>
        /// Generate identity for this entity
        /// </summary>
        public virtual void GenerateNewIdentity()
        {
            if (IsTransient())
                Id = IdentityGenerator.NewSequentialGuid();
        }

        /// <summary>
        /// Check if this entity is transient, ie, without identity at this moment
        /// </summary>
        /// <returns>True if entity is transient, else false</returns>
        public bool IsTransient() => EqualityComparer<Guid>.Default.Equals(Id, default);

        public void SetIdentity(Guid id)
        {
            if (IsTransient())
                Id = id;
            else
            {
                throw new InvalidOperationException("Entity already has identifier.");
            }
        }
    }
}
