using Demo.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Demo.Infrastructure.EF
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Students { get; set; }
    }
}
