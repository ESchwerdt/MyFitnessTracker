using FTLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace FTLibrary.DataAccess
{
    public class FitnessContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet <ActivityType> ActivityTypes { get; set; }

        public FitnessContext() 
            : base("name=FitnessContext")
        {

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Username).IsRequired();
        //        entity.Property(e => e.Password).IsRequired();
        //        entity.Property(e => e.FirstName).IsRequired();
        //        entity.Property(e => e.LastName).IsRequired();
        //        entity.Property(e => e.EmailAddress).IsRequired();
        //        entity.Property(e => e.Location).IsRequired(false);

        //    });

        //    modelBuilder.Entity<Activity>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Title).IsRequired();
        //        entity.Property(e => e.ActivityType).IsRequired();
        //        entity.Property(e => e.ActivityStart).IsRequired();
        //        entity.Property(e => e.ActivityDuration).IsRequired(false);
        //        entity.Property(e => e.ActivityDistance).IsRequired(false);
        //        entity.Property(e => e.ActivityNotes).IsRequired(false);
        //        entity.HasOne(d => d.User)
        //          .WithMany(p => p.Activities);
        //    });
        //}
    }
}
