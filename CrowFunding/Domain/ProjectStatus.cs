using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class ProjectStatus
    {
        public int Id { get; set; }
        [MaxLength (20)]
        public string Name { get; set; }
        public virtual ICollection<ProjectPage> ProjectPages { get; set; } 

        public ProjectStatus()
        {
            ProjectPages = new List<ProjectPage>();
        }
    }
}
