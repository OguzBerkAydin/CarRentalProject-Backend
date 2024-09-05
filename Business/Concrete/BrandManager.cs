using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class BrandManager : IBrandService
	{
		private readonly IBrandDal _brandDal;

		public BrandManager(IBrandDal brandDal)
		{
			_brandDal = brandDal;
		}

		public IResult Add(Brand car)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Brand car)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Brand>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<Brand> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Brand car)
		{
			throw new NotImplementedException();
		}
	}
}
