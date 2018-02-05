namespace StudentAPI.Migrations.Entities
{
    using StudentAPI.Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Entities";
            ContextKey = "StudentAPI.Models.ApplicationDbContext";
        }

        protected override void Seed(StudentAPI.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Students.AddOrUpdate(
                s => s.StudentId, DummyData.getStudents().ToArray()
                );

            context.SaveChanges();
        }
    }
}
