using JobChart.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JobChart.Controllers
{
    [Route("api/[controller]")]
    public class PieController : Controller
    {
        private readonly IPieService _service;

        public PieController(IPieService service)
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