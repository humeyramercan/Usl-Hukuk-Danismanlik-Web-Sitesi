using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
       public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<AreasOfExpertise> AreasOfExpertises { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}
