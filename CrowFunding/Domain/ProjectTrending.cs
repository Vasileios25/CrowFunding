using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class ProjectTrending
    {
        public int Id { get; set; }
        public int Views { get; set; }
        public ProjectPage ProjectPage { get; set; } = new();
    }
}
