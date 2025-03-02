﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		private readonly ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public void Add(Car car)
		{
			_carDal.Add(car);
		}

		public void Delete(Car car)
		{
			_carDal.Delete(car);
		}

		public List<Car> GetAll()
		{
			return _carDal.GetAll();
		}

		public Car GetById(int id)
		{
			return _carDal.GetById(car => car.Id == id);
		}

		public List<CarDetailDto> GetCarDetailDtos()
		{
			return _carDal.GetCarDetails();
		}

		public void Update(Car car)
		{
			_carDal.Update(car);
		}
	}
}
