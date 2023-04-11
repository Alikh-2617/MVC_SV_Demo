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

        public DbSet<Job> Jobs { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Continent> Continents { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            string job = "programer";
            int personId = 11111111;
            int house = 1;
            string registernumber = "415 GTA";
            string country = "danmark";
            string continent = "EURO";
            string PostNumber = "415 52";


            modelBuilder.Entity<Job>().HasData(new Job { JobName = job, Salary = 35000 });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = personId, Name = "Ali", EfterName = "khawari", Birthday = DateTime.Now, Register = DateTime.Now });
            modelBuilder.Entity<House>().HasData(new House { HouseNumber = house, Create = DateTime.Now });
            modelBuilder.Entity<Car>().HasData(new Car { RegisterNumber = registernumber, Color = "Red", Create = DateTime.Now, Model = "volo" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryName = country, Create = DateTime.Now });
            modelBuilder.Entity<Continent>().HasData(new Continent { ContinentName = continent, Create = DateTime.Now });
            modelBuilder.Entity<City>().HasData(new City { PostNumber = PostNumber, CityName = "Östersund", Create = DateTime.Now });

            modelBuilder.Entity<Job>().HasMany(x => x.People).WithMany(y => y.Jobs).UsingEntity(j => j.HasData(new { JobsJobName = job, PeoplePersonId = personId }));
        }
    }
}
