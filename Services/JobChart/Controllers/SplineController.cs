using JobChart.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JobChart.Controllers
{
    [Route("api/[controller]")]
    public class SplineController : Controller
    {
        private readonly ISplineService _service;

        public SplineController(ISplineService service)
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