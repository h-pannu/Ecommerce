using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _Context;
        public ProductController(DataContext context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _Context.Products.ToListAsync();
            return Ok(products);
        }
    }
}
