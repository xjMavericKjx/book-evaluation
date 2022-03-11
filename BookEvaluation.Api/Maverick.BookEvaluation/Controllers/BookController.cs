using Maverick.Books.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Maverick.BookEvaluation.Controllers
{
    [ApiController]
    [Route("api/v1/books")]
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(GetTestListOfBooks());
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            return null;
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            return Ok();
        }

        [Route("create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }

        [Route("edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return Ok();
        }

        [Route("edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }

        [Route("delete/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }

        private List<Book> GetTestListOfBooks()
        {
            var autor1 = new Autor("George Orwell");
            var autor2 = new Autor("Mikhail Bulgakov");
            var book1 = new Book("The Master and Margarita", "The Master and Margarita", 461, autor2.Id, new List<Books.Domain.Enums.Genres> { Books.Domain.Enums.Genres.Romance, Books.Domain.Enums.Genres.Fantasy });
            book1.Autor = autor2;
            var book2 = new Book("Nineteen Eighty-Four", "Nineteen Eighty-Four", 328, autor1.Id, new List<Books.Domain.Enums.Genres>{Books.Domain.Enums.Genres.Dystopian, Books.Domain.Enums.Genres.ScienceFiction });
            book2.Autor = autor1;
            return new List<Book>
            {
                book1,
                book2,
            };
        }
    }
}
