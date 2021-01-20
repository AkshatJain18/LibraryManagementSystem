using LibraryManagementSystem.Models.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSystem.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/books
        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return new Book[] { };
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public Book GetBookById(int id)
        {
            return new Book();
        }

        // GET api/books/filter/popular
        [Route("filter/popular")]
        public Book GetPopularBooks()
        {
            return new Book();
        }

        // POST api/books
        [HttpPost]
        public void PostBook([FromBody] Book book)
        {
        }

        // PUT api/books/5
        [HttpPut("{id}")]
        public void PutBook(int id, [FromBody] Book book)
        {
        }

        // DELETE api/books/5
        [HttpDelete("{id}")]
        public void DeleteBook(int id)
        {
        }
    }
}
