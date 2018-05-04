using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobChart.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JobChart.Controllers
{
    [Route("api/[controller]")]
    public class AutoController : Controller
    {
        private readonly IPolarService _service;

        public AutoController(IPolarService service)
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
