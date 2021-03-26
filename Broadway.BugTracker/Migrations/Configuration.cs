namespace Broadway.BugTracker.Migrations
{
    using Broadway.BugTracker.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Broadway.BugTracker.BugTrackerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Broadway.BugTracker.BugTrackerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.User.AddOrUpdate(new User()
            { Id=1,Username = "admin", Password = "admin@123",Role=Roles.Admin }
            );
            context.User.AddOrUpdate(new User()
            {Id=3 ,Username = "developer", Password = "developer@123", Role = Roles.Developer }
           );
            context.User.AddOrUpdate(new User()
            { Id=4,Username = "manager", Password = "manager@123", Role = Roles.ProjectManager }
           );
        }
    }
}
