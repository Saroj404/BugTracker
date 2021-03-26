using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.BugTracker.Model
{
    public class WorkItems
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AssigneeId { get; set; }
        public int? ReporterId { get; set; }

        [ForeignKey("AssigneeId")]
        public virtual User Assignee{get;set;}
        [ForeignKey("ReporterId")]
        public virtual User Reporter { get; set; }


    }
}
