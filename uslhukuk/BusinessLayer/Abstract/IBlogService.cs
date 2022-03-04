using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        List<Blog> BlogList();
        List<Blog> GetBlogsByStatus(bool status);
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        Blog GetBlogById(int id);
    }
}
