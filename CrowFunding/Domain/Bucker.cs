using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class Bucker 
    {
        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public List<Project> Project { get; set; } = new();

    }
}
