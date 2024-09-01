using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (CarRentalContext context = new())
			{
				var results = from car in context.Cars
							  join brand in context.Brands on car.BrandId equals brand.Id
							  join color in context.Colors on car.ColorId equals color.Id
							  select new CarDetailDto { BrandName = brand.Name, CarId = car.Id, CarName = car.Name, ColorName = color.Name };
				return results.ToList();
			}
			
		}
	}

}
