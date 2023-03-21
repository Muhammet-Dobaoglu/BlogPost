using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public List<Blog> TGetList()
		{
			return _blogDal.GetList();
		}

		public Blog TGetByID(int id)
		{
			return _blogDal.GetByID(id);
		}

		public void TInsert(Blog blog)
		{
			_blogDal.Insert(blog);
		}

		public void TDelete(Blog blog)
		{
			_blogDal.Delete(blog);
		}

		public void TUpdate(Blog blog)
		{
			_blogDal.Update(blog);
		}

		public List<Blog> TGetListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public List<Blog> TGetBlogByID(int id)
		{
			return _blogDal.GetListByFilter(x => x.BlogID == id);
		}

		public List<Blog> TGetListWithWriter(int id)
		{
			return _blogDal.GetListByFilter(x => x.WriterId == id);
		}
	}
}