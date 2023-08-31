using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using T_G.ECommerce.Business.Abstract;
using T_G.ECommerce.Core.Request;

namespace T_G.ECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult GetList([FromQuery] PageRequest pageRequest, [FromBody] Filter? filters)
        {
            var result = _productService.GetList(pageRequest, filters);
            return Ok(result);
        }
    }

}
