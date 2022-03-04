using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
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

        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public List<Blog> BlogList()
        {
            return _blogDal.List();
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog GetBlogById(int id)
        {
           return _blogDal.Get(x => x.BlogID == id);
        }

        public List<Blog> GetBlogsByStatus(bool status)
        {
           return _blogDal.ListGetById(x => x.BlogDurumu == status);
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
