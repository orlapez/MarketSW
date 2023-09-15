﻿using Market.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace Market.API.Data
{
    public class DataContext:DbContext
    {

        //Utilizar las propiedades y opciones de DBContext
        public DataContext(DbContextOptions<DataContext> options) : base(options) {



    }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }


}
