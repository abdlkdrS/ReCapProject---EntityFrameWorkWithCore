using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using System;
using Microsoft.EntityFrameworkCore;
using Entities.Concrate;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("CarId\t BrandName\t ColorName\t DailyPrice");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " \t " + car.BrandName + "\t" + car.ColorName + "\t" + car.DailyPrice);
            }




            
            
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());


            //CarList(carManager, brandManager, colorManager);

            //AddedTest(carManager, brandManager, colorManager);

            //DeletedTest(carManager, brandManager, colorManager);

            //UpdatedTest(carManager, brandManager, colorManager);

            //Console.WriteLine("Id'si 1 olan araç bilgileri..");
            //Console.WriteLine("Id - - BrandId - ColorId - ModelYear - DailyPrice - Description");
            //foreach (var car in carManager.GetByCarsId(1))
            //{
            //    Console.WriteLine(car.CarId + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.ModelYear + "\t" + car.DailyPrice + "\t" + car.Description);
            //}

            //Console.WriteLine("Günlük fiyatı 170 ile 100 arasındaki araçlar..");
            //Console.WriteLine("Id - - BrandId - ColorId - ModelYear - DailyPrice - Description");
            //foreach (var car in carManager.GetByDailyPrice(100, 170))
            //{
            //    Console.WriteLine(car.CarId + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.ModelYear + "\t" + car.DailyPrice + "\t" + car.Description);
            //}

            //Console.WriteLine("Model yılı 2018 olan araçlar..");
            //Console.WriteLine("Id - - BrandId - ColorId - ModelYear - DailyPrice - Description");
            //foreach (var car in carManager.GetByModelYear(2018))
            //{
            //    Console.WriteLine(car.CarId + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.ModelYear + "\t" + car.DailyPrice + "\t" + car.Description);
            //}

            //Console.WriteLine("Brand Id si 2 olan marka bilgileri..");
            //Console.WriteLine("BrandId - - BrandName");

            //Brand brand = brandManager.GetCarsByBrandId(2);
            //Console.WriteLine(brand.BrandId + "\t" + brand.BrandName);

            //Console.WriteLine("Color Id si 2 olan renk bilgileri..");
            //Console.WriteLine("ColorId - - ColorName");

            //Color color = colorManager.GetCarsByColorId(2);
            //Console.WriteLine(color.ColorId + "\t" + color.ColorName);


        }

        private static void UpdatedTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("Güncelleme Testi");
            carManager.Update(new Car { CarId = 6, BrandId = 4, ColorId = 4, ModelYear = 2018, DailyPrice = 190, Description = "Benzinli Otomatik" });
            colorManager.Update(new Color { ColorId = 4, ColorName = "Mat Siyah" });
            brandManager.Update(new Brand { BrandId = 4, BrandName = "Seat" });
        }

        private static void DeletedTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("Silme Testi..");
            carManager.Delete(new Car { CarId = 6, BrandId = 2, ColorId = 2, ModelYear = 2016, DailyPrice = 165, Description = "Benzinli Manuel" });
            colorManager.Delete(new Color { ColorId = 4, ColorName = "Kırmızı" });
            brandManager.Delete(new Brand { BrandId = 4, BrandName = "Honda" });
        }

        private static void AddedTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("Ekleme Testi..");
            carManager.Add(new Car { CarId = 6, BrandId = 2, ColorId = 2, ModelYear = 2016, DailyPrice = 165, Description = "Benzinli Manuel" });
            colorManager.Add(new Color { ColorId = 4, ColorName = "Kırmızı" });
            brandManager.Add(new Brand { BrandId = 4, BrandName = "Honda" });
        }

        private static void CarList(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            Console.WriteLine("Sistemde Bulunan Araçlar..");
            Console.WriteLine("Id - - BrandId - ColorId - ModelYear - DailyPrice - Description");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.ModelYear + "\t" + car.DailyPrice + "\t" + car.Description);
            }
            Console.WriteLine("****************************************************************");

            Console.WriteLine("Sistemde Kayıtlı Renkler..");
            Console.WriteLine("ColorId ColorName");
            foreach (var color in colorManager.GetAll())
            {

                Console.WriteLine(color.ColorId + "\t" + color.ColorName);
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Sistemde Kayıtlı Markalar..");
            Console.WriteLine("ColorId ColorName");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + "\t" + brand.BrandName);
            }
        }
    }
}
