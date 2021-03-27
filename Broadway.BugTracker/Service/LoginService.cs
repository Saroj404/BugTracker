using Broadway.BugTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.BugTracker.Service
{
    public class LoginService
    {
        public BugTrackerContext db = new BugTrackerContext();

        public (bool,string) Login(User model)
        {
            try
            {
                var existingUser = db.User.FirstOrDefault(p => p.Username == model.Username);
                
                
                if(existingUser!=null)
                {
                    //check password
                    if(existingUser.Password==model.Password)
                    {
                        return (true, "Login Successful!!!");
                    }
                    else
                    {
                        return (false, "Incorrect Password!");
                    }
                }
                else
                {
                    return (false, "Username not found!");
                }
            }
            catch (Exception ex)
            {

                return (false, ex.Message);
            }

        }
        public List<User>GetAll()
        {
            return db.User.ToList();

        }
    }
}
