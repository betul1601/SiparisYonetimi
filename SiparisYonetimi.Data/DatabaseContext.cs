using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity; //bu kütüphane entity framework paketinden geliyor
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi.Data
{
    public class DatabaseContext : DbContext //burada entity frameworkün Dbcontext sınıfından miras alıyoruz databasecontext sınıfında dbcontext leri kullanabilmek için
    {
        public DatabaseContext()
        {

        }
        public virtual DbSet <Brand> Brands { get; set; }
        public virtual DbSet <Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
