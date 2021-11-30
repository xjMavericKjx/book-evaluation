
using System;
using System.Collections.Generic;

namespace Maverick.Books.Domain
{
    using Enums;

    public class Book : Entity
    {
        public Book(string title, string description, int pageCount, Guid autorId, List<Genres> genres)
        {
            AutorId = autorId;
            Description = description;
            Title = title;
            PageCount = pageCount;
            Genres = genres;
            GenerateNewIdentity();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public List<Genres> Genres { get; set; }
        public int PageCount { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual Guid AutorId { get; set; }
    }
}
