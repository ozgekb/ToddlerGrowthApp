using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace ToddlerGrowthApp
{
    class ToddlerGrowthContext : DbContext
    {
        public DbSet<Baby> Babies { get; set; }
        public DbSet<User> Users { get; set; }
 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseSqlServer(@"Data Source =localhost; User Id=sa; Password=Sami1499!; Initial Catalog=ToddlerGrowth;");

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            /*
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

            });
            */
            modelBuilder.Entity<Baby>(entity =>
            {
                entity.ToTable("Babies");
                entity.HasKey(i => i.BabyId);
                entity.Property(i => i.BabyId).ValueGeneratedOnAdd();
                entity.Property(i => i.BabyName).IsRequired().HasMaxLength(300);
                entity.Property(i => i.BabySex).IsRequired();
                entity.Property(i => i.BirthDate);
                entity.Property(i => i.BirthPlace);
                entity.Property(i => i.BirthWeight);
                entity.Property(i => i.BirthHeight);
                // entity.Property(i => i.SleepingTrack).IsRequired();
                //entity.Property(i => i.BirthHeadCircumference).IsRequired();
                // entity.Property(i => i.BirthHospital).IsRequired();
                // entity.Property(i => i.DoctorName).IsRequired();
            });

            modelBuilder.Entity<SleepingTrack>(entity =>
            {
                entity.ToTable("SleepingRecord");
                entity.HasKey(i => i.SleepingTrackId);
                // entity.HasNoKey();
                // entity.Property(i => i.BabyId);
                entity.Property(i => i.StartDateTime);
                entity.Property(i => i.EndDateTime);

            });


            
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(i => i.Email);
                entity.Property(i => i.Name).IsRequired().HasMaxLength(100);
                entity.Property(i => i.LastName).IsRequired().HasMaxLength(250);
                entity.Property(i => i.Password);
                entity.Property(i => i.CreatedDate);

            });

            /*

            modelBuilder.Entity<FeedingTrack>(entity =>
            {
                entity.ToTable("FeedingRecord");
                entity.HasNoKey();
               // entity.Property(i => i.BabyId);
                entity.Property(i => i.StartDateTime);
                entity.Property(i => i.EndDateTime);

            });



            modelBuilder.Entity<WeightRecords>(entity =>
            {
                entity.ToTable("WeightRecord");
                entity.HasNoKey();
               // entity.Property(i => i.BabyId);
                entity.Property(i => i.WeightEntryDate);
                entity.Property(i => i.Weight);

            });

            modelBuilder.Entity<HeightRecords>(entity =>
            {
                entity.ToTable("HeightRecord");
                entity.HasNoKey();
                //entity.Property(i => i.BabyId);
                entity.Property(i => i.HeightEntryDate);
                entity.Property(i => i.Height);

            });

        */

        }
    }

    }

