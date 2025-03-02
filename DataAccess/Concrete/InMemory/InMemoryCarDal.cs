﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;

		public InMemoryCarDal()
		{
			_cars = new List<Car>
			{
				
				new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 10, ModelYear="2010", Description="boyalı" },
				new Car { Id = 2, BrandId = 1, ColorId = 3, DailyPrice = 20, ModelYear="2012", Description="kapısı kırık" },
				new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 30, ModelYear="2011", Description="kaporta yok" },		
			};
		}

		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
			_cars.Remove(carToDelete);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public Car GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Car GetById(Expression<Func<Car, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<CarDetailDto> GetCarDetails()
		{
			throw new NotImplementedException();
		}

		public void Update(Car car)
		{
			throw new NotImplementedException();
		}
	}
}
