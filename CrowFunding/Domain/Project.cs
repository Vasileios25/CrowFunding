using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public  string Description {get; set;}
        public string Video { get; set; }
        public string Image { get; set; }

        public bool PostStatus { get; set; } = true;
        public ProjectCategory ProjectCategory { get; set; }
        public System.DateTime DateInserted { get; set; }

    }
}
