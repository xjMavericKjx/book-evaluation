using System;

namespace Maverick.Books.Domain
{
    public interface IEntity
    {
        Guid Id { get; }
        bool IsTransient();
    }
}
