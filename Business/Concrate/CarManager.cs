using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);

                Console.WriteLine("Arac Ekleme Başarılı..");
            }
            else
            {
                Console.WriteLine("Marka günlük fiyatı 0 dan büyük olmalı..");
            }

        }

        public IEnumerable<object> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByCarsId(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetByModelYear(int year)
        {
            return _carDal.GetAll(c => c.ModelYear == year);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);

                Console.WriteLine("Arac Güncelleme Başarılı..");
            }
            else
            {
                Console.WriteLine("Marka günlük fiyatı 0 dan büyük olmalı..");
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
