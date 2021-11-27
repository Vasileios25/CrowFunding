using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class Basket
    {

        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("BuckerId")]
        public Bucker Bucker { get; set; }
       
        public virtual List<Project> Projects { get; set; }
    }
}
