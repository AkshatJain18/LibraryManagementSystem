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
        public IEnumerable<Author> Get()
        {
            return new Author[] {};
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return new Author();
        }

        // POST api/authors
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/authors/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Author value)
        {
        }

        // DELETE api/authors/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
