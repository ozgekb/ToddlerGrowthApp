using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace ToddlerGrowthApp
{
    class ToddlerGrowthContext : DbContext
    {
            public DbSet<UsedItem> UsedItems { get; set; } 
           
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseSqlServer(@"Data Source =localhost; User Id=sa; Password=Sami1499!; Initial Catalog=ToddlerGrowth;");

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
               
                modelBuilder.Entity<UsedItem>(entity =>
                {
                    entity.ToTable("UsedItems");
                    entity.HasKey(i => i.ItemId);
                    entity.Property(i => i.ItemId).ValueGeneratedOnAdd();
                    entity.Property(i => i.ItemName).IsRequired().HasMaxLength(100);
                    entity.Property(i => i.ItemColor).IsRequired().HasMaxLength(250);
                    entity.Property(i => i.ItemDescription).IsRequired();
                    entity.Property(i => i.ItemPrice).IsRequired();
                    entity.Property(i => i.Quantity).IsRequired();

                }

                );
             
            }
        }

    }




