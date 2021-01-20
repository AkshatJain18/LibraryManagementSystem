using LibraryManagementSystem.Models.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSystem.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET: api/customers
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return new Customer[] {  };
        }

        // GET api/customers/5
        [HttpGet("{id}")]
        public Customer GetCustomerById(int id)
        {
            return new Customer();
        }

        // GET api/customers/5/outstanding
        [Route("{id}/outstanding")]
        public double GetCustomerDueAmount(int id)
        {
            return 200;
        }

        // POST api/customers
        [HttpPost]
        public void PostCustomer([FromBody] Customer customer)
        {
        }

        // PUT api/customers/5
        [HttpPut("{id}")]
        public void PutCustomer(int id, [FromBody] Customer customer)
        {
        }

        // DELETE api/customers/5
        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
        }
    }
}
