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
	public class ColorManager : IColorService
	{
		private readonly IColorDal _colorDal;

		public ColorManager(IColorDal colorDal)
		{
			_colorDal = colorDal;
		}

		public IResult Add(Color car)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Color car)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Color>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<Color> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Color car)
		{
			throw new NotImplementedException();
		}
	}
}
