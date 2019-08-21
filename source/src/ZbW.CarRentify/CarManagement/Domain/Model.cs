using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZbW.CarRentify.Common;

namespace ZbW.CarRentify.CarManagement.Domain
{
    public class Model : EntityBase
    {
        private Brand _brand;
        private CarClass _carClass;

        public Model()
        {
        }

        public Model(Brand brand, CarClass carClass)
        {
            _brand = brand;
            _carClass = carClass;
        }

        public Brand Brand => _brand;

        public CarClass CarClass => _carClass;
    }
}
