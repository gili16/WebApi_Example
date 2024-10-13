using BL;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IBL<Product> productBL;
        public ProductController(IBL<Product> productBL)
        {
            this.productBL = productBL;
        }
        // GET: api/<Product_Controller>
        [HttpGet]
        public List<Product> Get()
        {
            return productBL.getAll();
        }

        // GET api/<Product_Controller>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productBL.getById(id);
        }

        // POST api/<Product_Controller>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            
            productBL.AddItem(value);
        }

        // PUT api/<Product_Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            productBL.update(id, value);
        }

        // DELETE api/<Product_Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productBL.deleteById(id);
        }
    }
}
