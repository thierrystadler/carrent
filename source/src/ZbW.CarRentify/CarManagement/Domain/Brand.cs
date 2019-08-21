using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZbW.CarRentify.Common;

namespace ZbW.CarRentify.CarManagement.Domain
{
    public class Brand : EntityBase
    {
        private List<Model> _models;

        public Brand()
        {
            _models = new List<Model>();
        }

        public IReadOnlyList<Model> Models => _models;
    }
}
