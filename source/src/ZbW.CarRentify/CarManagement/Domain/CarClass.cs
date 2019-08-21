using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZbW.CarRentify.Common;

namespace ZbW.CarRentify.CarManagement.Domain
{
    public class CarClass : EntityBase
    {
        private string _name;

        private decimal _dailyFee;

        public CarClass()
        {
        }

        public CarClass(string name, decimal dailyFee)
        {
            _name = name;
            _dailyFee = dailyFee;
        }

        public string Name => _name;

        public decimal DailyFee => _dailyFee;
    }
}
