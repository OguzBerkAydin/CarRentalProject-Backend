﻿using Entities.Concrete;

namespace Business.Abstract
{
	public interface IColorService
	{
		List<Color> GetAll();
		Color GetById(int id);
		void Add(Color car);
		void Update(Color car);
		void Delete(Color car);
	}
}
