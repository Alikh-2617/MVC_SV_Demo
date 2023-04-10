using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataCantext
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var OpsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            OpsBuilder.UseSqlServer(appConfig.sqlConnectionString);
            return new ApplicationDbContext(OpsBuilder.Options);    
        }
    }
}
