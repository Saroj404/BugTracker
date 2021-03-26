using Broadway.BugTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.BugTracker.Service
{
    public class WorkItemservice
    {
        private BugTrackerContext db = new BugTrackerContext();
        public(bool,string) CreateWorkItem(WorkItems item )
        {
            try
            {
                db.WorkItem.Add(item);
                db.SaveChanges();
                return (true, "Workitem created successfully");

            }
            catch (Exception ex)
            {
                return (false, ex.Message);
                
            }
        }

        public List<WorkItems>GetAll()
        {
            return db.WorkItem.ToList();
        }
        public WorkItems Getbyid(int id)
        {
            return db.WorkItem.Find(id);
        }

    }
}
