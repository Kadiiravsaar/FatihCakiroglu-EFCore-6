using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DatabaseFirst.DataAccessLayer
{
    public class DbContextInitializer
    {
        public static IConfigurationRoot Configuration; // Appsettings dosyasını okuabilmek için    
        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder; // Db ile optionsları belirtilecek yer

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange:true);

            Configuration = builder.Build();
            OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));

        }



    }
}
