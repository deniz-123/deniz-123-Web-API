using System;
using Microsoft.EntityFrameworkCore;
using XML.ENTITIES;

namespace XML.DATA
{
    public class ItemDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ItemsDb;user=root;password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.UUID).IsRequired();
                entity.Property(e => e.IssueDate).IsRequired();
                entity.Property(e => e.SupplierVKN).IsRequired();
                entity.Property(e => e.TotalAmount).IsRequired();
                entity.Property(e => e.Customer).IsRequired();
            });
        }
    }
}
