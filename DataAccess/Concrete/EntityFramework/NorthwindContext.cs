using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{ // DB tabloları ile proje classlarını bağlamak içindir bu nesne
  // DbContext 'i implemente ediyoruz.Bu NuGet ile gelen base sınıfımız olan context nesnesi
    public class NorthwindContext:DbContext
    { // class içine over yazdıktan sonra override ye ENTER a bas daha sonra OnConfuring ' e taba bas oluşur
      // base. ile başlayan yeri sil.
      // Daha sonra SQL Server penceresinden SQL serverin nerede olduğunu gösteren string i yazıyoruz.
      // Database : terimi ile veritabanı adını yazıyoruz
      // Trusted_Connection : ise güvenli bağlantıyı açıyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True");
        }
        // prop ile de DbSet<> syntax ini kullanıp veritabanı tablomuz ile classlarımızı bağlıyoruz.
        // Yani Veritabanındaki hangi tablo ile hangi sınıfla çalışacak
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
