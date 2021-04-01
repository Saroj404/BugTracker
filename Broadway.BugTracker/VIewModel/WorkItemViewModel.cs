using Broadway.BugTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.BugTracker.VIewModel
{
   public class WorkItemViewModel
    {
        public int id { get; set; }
        public string Title { get; set; }

        public string AssigneeName { get; set; }
        public string ReporterName { get; set; }

        public WorkItemStatus Status { get; set; }

        public override string ToString()
        {
            return this.id + ": " + this.Title;
        }
    }
}
