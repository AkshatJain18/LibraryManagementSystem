using LibraryManagementSystem.Models.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSystem.Controllers
{
    [Route("api/fines")]
    [ApiController]
    public class FinesController : ControllerBase
    {
        // GET: api/fines
        [HttpGet]
        public IEnumerable<Fine> GetAllFines()
        {
            return new Fine[] { };
        }

        // GET api/fines/5
        [HttpGet("{id}")]
        public Fine GetFineById(int id)
        {
            return new Fine();
        }

        // POST api/fines
        [HttpPost]
        public void PostFine([FromBody] Fine fine)
        {
        }

        // PUT api/fines/5
        [HttpPut("{id}")]
        public void PutFine(int id, [FromBody] Fine fine)
        {
        }

        // DELETE api/fines/5
        [HttpDelete("{id}")]
        public void DeleteFine(int id)
        {
        }
    }
}
