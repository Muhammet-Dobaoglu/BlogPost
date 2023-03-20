using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TDelete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public List<Comment> TGetBlogByID(int id)
        {
            return _commentDal.GetListByFilter(x => x.BlogId == id);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public void TUpdate(Comment comment)
        {
            _commentDal.Update(comment);
        }

		public List<Comment> TGetList()
		{
			throw new NotImplementedException();
		}
	}
}