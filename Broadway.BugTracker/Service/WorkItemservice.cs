using Broadway.BugTracker.Model;
using Broadway.BugTracker.VIewModel;
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

        public List<WorkItemViewModel>GetAll()
        {
            var workitems = db.WorkItem.ToList();
           var listworkitems=workitems.Select(p => new WorkItemViewModel
            {
                id=p.id,
                Title=p.Title,
                AssigneeName=p.Assignee==null?"":p.Assignee.Username,
                ReporterName=p.Reporter==null?"":p.Reporter.Username,
            }).ToList();

            return listworkitems;
        }
        public WorkItems Getbyid(int id)
        {
            return db.WorkItem.Find(id);
        }

    }
}
