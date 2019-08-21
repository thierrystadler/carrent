using System;
using System.Collections.Generic;
using System.Data.Common;
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
            return _carService.GetAll().Select(x =>
                new CarDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Model = x.Model.ToString(),
                    Brand = x.Model.Brand.ToString()
                }
            );
        }

        [HttpGet("{id}", Name = "Get")]
        public CarDTO Get(Guid id)
        {
            var car = _carService.Get(id);

            return new CarDTO
            {
                Id = car.Id,
                Name = car.Name,
                Model = car.Model.ToString(),
                Brand = car.Model.Brand.ToString()
            };
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
