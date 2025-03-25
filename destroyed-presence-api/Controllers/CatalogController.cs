using Microsoft.AspNetCore.Mvc;
using destroyed.presence.Domain.Catalog;

namespace destroyed.presence.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetItems(){
            return Ok("Hello World!");
        }
    }
}
