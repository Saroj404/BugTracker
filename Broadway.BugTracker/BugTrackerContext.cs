using Broadway.BugTracker.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Broadway.BugTracker
{
    public class BugTrackerContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Broadway.BugTracker' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public  BugTrackerContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<User> User{ get; set; }
        public virtual DbSet<WorkItems> WorkItem { get; set; }

    }

   
}