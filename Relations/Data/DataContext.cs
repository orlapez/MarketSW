using Microsoft.EntityFrameworkCore;
using Relations.Entities;

namespace Market.API.Data
{
    public class DataContext:DbContext
    {

        //Utilizar las propiedades y opciones de DBContext
        public DataContext(DbContextOptions<DataContext> options) : base(options) {



    }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryProduct> Categories { get; set; }

        public DbSet<CategoryProduct> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Country>().HasIndex(c=>c.Name).IsUnique();  


        }

    }


}
