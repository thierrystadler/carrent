using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZbW.CarRentify.CarManagement.Services;

namespace ZbW.CarRentify.CarManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IEnumerable<CarDTO> Get()
        {
            return new[] {
                new CarDTO { Name = "Mercedes Benz"},
                new CarDTO { Name = "Bugatti" }
            };
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(new CarDTO());
            }
            catch (EntryPointNotFoundException ex)
            {
                base.NotFound();
            }
        }

        [HttpPost]
        public void Post([FromBody] CarDTO car)
        {
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarDTO car)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
