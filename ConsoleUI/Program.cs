using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//InMemoryTest();

			CarManager carManager = new(new EfCarDal());

            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine("Car Name : {0}, Brand Name : {1}, Color Name : {2}",car.CarName, car.BrandName, car.ColorName);
            }

            Console.WriteLine("Hello, World!");
		}

		private static void InMemoryTest()
		{
			CarManager carManager = new CarManager(new InMemoryCarDal());
			var results = carManager.GetAll();

			foreach (var car in results)
			{
				Console.WriteLine("{0} {1} {2}", car.ModelYear, car.Description, car.DailyPrice);
			}
		}
	}
}
