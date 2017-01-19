using Microsoft.EntityFrameworkCore;
using SampleEFCoreMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEFCoreMigration.DAL
{
    public class SampleEFCoreMigrationContext : DbContext
    {
        public SampleEFCoreMigrationContext(DbContextOptions<SampleEFCoreMigrationContext> options) : base(options)
        {
        }

        public DbSet<Chemical> Chemicals { get; set; }

        // The commented code below allows you to override the default pluralization of the Table name 
        //  Coders disagree of whether to pluralize table name or not... 
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
        }
        */
    }
}
