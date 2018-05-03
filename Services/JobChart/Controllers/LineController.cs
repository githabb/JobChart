using JobChart.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JobChart.Controllers
{
    [Route("api/[controller]")]
    public class LineController : Controller
    {
        private readonly ILineService _service;

        public LineController(ILineService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()

        {
            var result = await _service.Get();

            return Ok(result);
        }

    }
}