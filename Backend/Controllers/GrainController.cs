using System;
using Microsoft.AspNetCore.Mvc;
using Backend.Services;

namespace Backend.Controllers
{
    [Route("api/rest/{controller}")]
    [ApiController]
    public class GrainController: ControllerBase
    {
        private readonly IGrainService service;

        public GrainController()
        {
            service = new GrainServiceImpl();
        }

        [HttpGet("")]
        public IActionResult All()
        {
            return Ok(service.All());
        }

        [HttpGet("date-range")]
        public IActionResult DateRange(DateTime? startDate, DateTime? endDate)
        {
            if (startDate == null || endDate == null || endDate < startDate)
            {
                return BadRequest();
            }
            return Ok(service.GetDateRange((DateTime)startDate, (DateTime)endDate));
        }

        [HttpGet("info")]
        public IActionResult Info()
        {
            return Ok(service.Info());
        }

    }
}
