using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZbW.CarRentify.CarManagement.Domain;

namespace ZbW.CarRentify.CarManagement.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetAll();

        Car Get(Guid id);
    }
}
