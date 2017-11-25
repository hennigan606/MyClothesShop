using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyClothesShop.Models
{
    public class ProductDb : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}