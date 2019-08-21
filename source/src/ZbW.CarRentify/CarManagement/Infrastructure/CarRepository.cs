﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZbW.CarRentify.CarManagement.Domain;
using ZbW.CarRentify.Common;

namespace ZbW.CarRentify.CarManagement.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
        }
        public void Delete(Car entity)
        {
            _carContext.Cars.Remove(entity);
        }

        public Car Get(Guid id)
        {
            var car = _carContext.Cars.Find(id);
            if (car == null)
            {
                throw new EntityNotFoundException();
            }

            return car;
        }

        public IEnumerable<Car> GetAll()
        {
            return _carContext.Query<Car>().ToList();
        }

        public void Insert(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}