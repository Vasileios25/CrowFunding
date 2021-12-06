
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class ProjectBacker
    {
        public int Id { get; set; }
        public int TotalSpent { get; set; }
        public string Progress { get; set; }
        public virtual ProjectPage Project { get; set; }
        public DateTime Datetime { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
    }
        
}
