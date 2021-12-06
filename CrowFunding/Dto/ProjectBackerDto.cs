using CrowFunding.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Dto
{
    public class ProjectBackerDto
    {

        public int id { get; set; }

        public ProjectCategory projectCategory { get; set; }
        public DateTime dateTime { get; set; }
        public ProjectDto projectDto { get; set; }
        public string  Progress { get; set; }
        public int TotalSpent { get; set; }
    }
}
