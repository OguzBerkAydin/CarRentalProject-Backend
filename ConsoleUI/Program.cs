using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//InMemoryTest();
			//Car car1 = new() { BrandId = 1, ColorId = 1, DailyPrice = 10, Description = "asd", ModelYear = "1000", Name = "mercedes a10" };
			//Car car2 = new() { BrandId = 2, ColorId = 3, DailyPrice = 10, Description = "asd", ModelYear = "1000", Name = "bmw a10" };
			//Car car3 = new() { BrandId = 3, ColorId = 2, DailyPrice = 10, Description = "asd", ModelYear = "1000", Name = "audi a10" };

			//Brand brand1 = new() { Name = "mercedes" };
			//Brand brand2 = new() { Name = "bmw" };
			//Brand brand3 = new() { Name = "audi" };

			//Color color1 = new() { Name = "Siyah" };
			//Color color2 = new() { Name = "Beyaz" };
			//Color color3 = new() { Name = "Gri" };



			CarManager carManager = new(new EfCarDal());
			//carManager.Add(car1);
			//carManager.Add(car2);
			//carManager.Add(car3);

			//BrandManager brandManager = new(new EfBrandDal());
			//brandManager.Add(brand1);
			//brandManager.Add(brand2);
			//brandManager.Add(brand3);

			//ColorManager colorManager = new(new EfColorDal());
			//colorManager.Add(color1);
			//colorManager.Add(color2);
			//colorManager.Add(color3);

			var results = carManager.GetAll();
			var datas = results.Data;
			

			//foreach (var car in carManager.GetCarDetailDtos().Data.Where(c=> c.BrandName == "audi"))
			//{
			//	Console.WriteLine("Car Name : {0}, Brand Name : {1}, Color Name : {2}", car.CarName, car.BrandName, car.ColorName);
			//}

			foreach (var car in datas)
			{
				Console.WriteLine(car.Name+car.Description+car.DailyPrice);
			}

			Console.WriteLine("Hello, World!");
		}

		private static void InMemoryTest()
		{
			CarManager carManager = new CarManager(new InMemoryCarDal());
			var results = carManager.GetAll().Data;

			foreach (var car in results)
			{
				Console.WriteLine("{0} {1} {2}", car.ModelYear, car.Description, car.DailyPrice);
			}
		}
	}
}
