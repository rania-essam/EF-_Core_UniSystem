using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EFday1_UniversitySystem.Models
{
    public class DB_Context:DbContext
    {
        public DB_Context() :base()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=.;Database=UniversitySystem;Trusted_Connection=True;TrustServerCertificate=True")
                .LogTo(mess => Debug.WriteLine(mess),
                   new[] { DbLoggerCategory.Database.Command.Name },
                   Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().Property(d => d.Name).IsRequired(true);
          //  modelBuilder.Entity<Department>().HasKey(d => new { d.Name, d.Id });     // composite pk
            modelBuilder.Entity<Department>()
      .HasOne(d => d.Instructor)
      .WithOne(i => i.Department)
      .HasForeignKey<Department>("InstructorId");


            modelBuilder.Entity<Student>()
                .Property(st => st.Age)
                .IsConcurrencyToken();

            // Global Query Filter
                  modelBuilder.Entity<Student>().HasQueryFilter(st => !st.IsDeleted);
            /*
             every query related to student contains silently
             where st.IsDeleted == false ;
             */

            //shadow property
            modelBuilder.Entity<Department>()
                .Property<bool>("Is_Deleted");

            // adding shadow property to all entities all at once 
            foreach (var item in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(item.Name)
                    .Property<bool>("Is_Deleted").IsRequired(true).HasDefaultValue(false);
            }

        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Student> Students { get; set; }

    }
}
