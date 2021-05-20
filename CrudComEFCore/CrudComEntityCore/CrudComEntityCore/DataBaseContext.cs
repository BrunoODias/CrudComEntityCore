using CrudComEntityCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudComEntityCore
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<Book> Books { get; set; }
        public IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration["ConnectionString"]);
        }
    }
}
