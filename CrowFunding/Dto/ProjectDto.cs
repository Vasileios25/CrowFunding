using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CrowFunding.Dto
{
    public class ProjectDto
    {
       
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public bool StatusUpdate { get; set; }
        public UserDto User { get; set; }
        //public List<>

    }
}
