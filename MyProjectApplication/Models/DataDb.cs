﻿using Microsoft.EntityFrameworkCore;

namespace MyProjectApplication.Models
{
    public class DataDb : DbContext
    {
        public DataDb(DbContextOptions<DataDb> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}