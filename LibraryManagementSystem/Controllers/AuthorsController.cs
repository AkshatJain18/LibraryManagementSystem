using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models.Core;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSystem.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        // GET: api/authors
        [HttpGet]
        public IEnumerable<Author> GetAllAuthors()
        {
            return new Author[] {};
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public Author GetAuthorById(int id)
        {
            return new Author();
        }

        // GET api/authors/1/books
        [Route("{id}/books")]
        public IEnumerable<Book> GetAuthorBooks(int id)
        {
            return new Book[] { };
        }

        // POST api/authors
        [HttpPost]
        public void PostAuthor([FromBody] Author author)
        {
        }

        // PUT api/authors/5
        [HttpPut("{id}")]
        public void PutAuthor(int id, [FromBody] Author author)
        {
        }

        // DELETE api/authors/5
        [HttpDelete("{id}")]
        public void DeleteAuthor(int id)
        {
        }
    }
}
