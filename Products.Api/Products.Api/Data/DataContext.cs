using Microsoft.EntityFrameworkCore;
using Products.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
