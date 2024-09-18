﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}
		public void TAdd(About entity)
		{
			_aboutDal.Add(entity);
		}

		public void TDelete(About entity)
		{
			_aboutDal.Delete(entity);
		}

		public About TGetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public List<About> TGetList()
		{
			return _aboutDal.GetList();
		}

		public void TUpdate(About entity)
		{
			_aboutDal.Update(entity);
		}
	}
}
