using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IBrandService
	{
		IDataResult<List<Brand>> GetAll();
		IDataResult<Brand> GetById(int id);
		IResult Add(Brand car);
		IResult Update(Brand car);
		IResult Delete(Brand car);
	}
}
