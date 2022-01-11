using DutchGo.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;


namespace DutchGo.Data
{
    public class DutchContext : DbContext
    {
        private readonly IConfiguration _config;
        public DutchContext(IConfiguration config)
        {
            _config = config;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DutchContextDb"]);
        }
    }
}