using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class Creator 
    {
        public int Id { get; set; }

       
        public string Location { get; set; }
        public List<Project> Project { get; set; } = new();
        public int? ProfileId  { get; set; }

    }
}
