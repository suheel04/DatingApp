
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
    {
    }

    public DataContext(DbContextOptions options) : base(options)
    {
    }

        protected DataContext(DbContextOptions<DataContext> options) : base(options){}
       
       public DbSet<Value> Values { get; set; }
    }
}