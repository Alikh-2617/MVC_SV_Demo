using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.DataCantext
{
    public class AppConfiguration
    {  // config för app 
       // packege = EntityFrameWorkCore , extentin.configuration , configuration.Json
        public AppConfiguration()
        {
            //skapa en variabel av Configuration class 
            var configBuilder = new ConfigurationBuilder();
                     // path = routing with input and out , Combine = Combaing in routing in this path ,
                     // Directory = in i en directory , GetCurrenDirectory = läs den data i den dirctory som har den "Root Directory Namn"
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path , false);

            var root = configBuilder.Build();
            var appsetting = root.GetSection("ConnectionStrings:DefualtConnection");  // med hjälp av root som skapades läs en Section för mig som hetter (ConnectionStrign)

            sqlConnectionString = appsetting.Value;   // skapat en sqlCoonection med vale som ligger i appsetting

        }
        public string sqlConnectionString { get; set; }   // vi kommer använda den i ApplicationDbContext

    }
}
