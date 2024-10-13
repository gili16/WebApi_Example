using BL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IBL<Order> productBL;
        public OrderController(IBL<Order> productBL)
        {
            this.productBL = productBL;
        }
        // GET: api/<BookController>
        [HttpGet]
        public List<Order> Get()
        {
            return productBL.getAll();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return productBL.getById(id);
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] Order value)
        {
            productBL.AddItem(value);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order value)
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
