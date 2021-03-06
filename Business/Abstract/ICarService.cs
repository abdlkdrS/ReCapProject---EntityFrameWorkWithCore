﻿using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByCarsId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByModelYear(int year);

        List<CarDetailDto> GetCarDetails();

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);
    }
}
