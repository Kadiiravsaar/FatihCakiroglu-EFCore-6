using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DatabaseFirst.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        
        public DbSet<Product> Products { get; set; }
        // DbSet<Product> -Burada yazdığın isim veritabanındaki isme denk gelmektedir-

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-G34LNC7;Initial Catalog=EFCoreDatabaseFirstDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

           
           // farklı farklı db'ye bağlanabilmek için bi builder alıyoruz.
        }

        // override yapıp sql server'e bağlantı cümleciği yazmak
    }
}
