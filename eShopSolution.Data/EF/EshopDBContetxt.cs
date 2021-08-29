using eShopSolution.Data.Entiles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EshopDBContetxt : DbContext
    {
        public EshopDBContetxt(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Categories { get; set; }
    }
}
