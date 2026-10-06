using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_16_IntroEFCoreDbContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "app.db");
            dbPath = Path.GetFullPath(dbPath);
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
