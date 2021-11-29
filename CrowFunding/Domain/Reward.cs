using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class Reward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateInserted { get; set; }
        public DateTime EstimatedShipping { get; set; }
        public string Description { get; set; }
        public string IncludeItems { get; set; }
        public bool IsAvailable { get; set; }
        public int Inventory { get; set; }
        public int FeeAmount { get; set; }
        public virtual Project Project { get; set; }
        public int ProjectPageId { get; set; }



    }
}
