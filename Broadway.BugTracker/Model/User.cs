using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.BugTracker.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

    }
    public enum Roles
    {
        Admin=1,
        Developer=0,
        ProjectManager=2 
    }

    public enum ItemTypes
    {
        Task,
        Bug
    }

}
