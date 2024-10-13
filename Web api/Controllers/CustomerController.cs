using BL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IBL<Customer> productBL;
        public CustomerController(IBL<Customer> productBL)
        {
            this.productBL = productBL;
        }
        // GET: api/<BookController>
        [HttpGet]
        public List<Customer> Get()
        {
            return productBL.getAll();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return productBL.getById(id);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            productBL.AddItem(value);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            productBL.update(id, value);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productBL.deleteById(id);
        }
    }
}
