﻿using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfBrandDal : EfEntityRepositoryBase<Brand, CarRentalContext>, IBrandDal
	{
	}

}
