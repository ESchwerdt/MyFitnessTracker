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


    }
}
