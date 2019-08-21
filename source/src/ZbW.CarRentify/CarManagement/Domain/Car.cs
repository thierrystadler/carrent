using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZbW.CarRentify.Common;

namespace ZbW.CarRentify.CarManagement.Domain
{
    public class Car : EntityBase
    {
        private Model _model;

        public Car()
        {
        }

        public Car(Model model)
        {
            _model = model;
        }

        public Model Model => _model;

        public string Name { get; set; }
    }
}
