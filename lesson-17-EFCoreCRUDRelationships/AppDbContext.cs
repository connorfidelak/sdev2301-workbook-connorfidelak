using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_17_EFCoreCRUDRelationships
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        protected override void OnConfiguring(
        DbContextOptionsBuilder options)
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "store.db");
            dbPath = Path.GetFullPath(dbPath);
            options.UseSqlite($"Data Source={dbPath}");

            base.OnConfiguring(options);
        }
    }
}
