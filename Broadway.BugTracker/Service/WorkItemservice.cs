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
                Status=p.Status
            }).ToList();

            return listworkitems;
        }
        public WorkItems Getbyid(int id)
        {
            return db.WorkItem.Find(id);
        }

        public (bool,string) ChangestateofWorkItem(int id ,WorkItemStatus status)
        {
            try
            {
                var item = db.WorkItem.Find(id);
                if(item==null)
                {
                    return (false, "Item not found");
                }
                else
                {
                    item.Status = status;
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return (true, "Item updated");
                }
            }
            catch (Exception ex)
            {

                return (false, ex.Message);
            }
        }

    }
}
