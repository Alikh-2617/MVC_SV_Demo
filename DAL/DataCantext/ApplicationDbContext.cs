using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataCantext
{
    public class ApplicationDbContext : DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                // pakege SqlServer 
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);  
                dbOptions = opsBuilder.Options; 
            }

            public DbContextOptionsBuilder<ApplicationDbContext> opsBuilder { get; set; }
            public DbContextOptions<ApplicationDbContext> dbOptions { get; set; }
            private AppConfiguration settings;
        }

        public static OptionsBuild ops = new OptionsBuild();
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Person> People { get; set; }
        public DbSet<City> cities { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
