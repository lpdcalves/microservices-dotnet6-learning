﻿using Microsoft.EntityFrameworkCore;

namespace OnlineShoppingExample.ProductAPI.Model.Context
{
    public class ProductContext :DbContext
    {
        public ProductContext() { }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
