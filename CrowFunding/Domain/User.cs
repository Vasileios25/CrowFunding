using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class User
    {
        


        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<ProjectBacker> ProjectsBacker { get; set; }
        public virtual ICollection<ProjectPage> ProjectPages { get; set; }
        public User()
        {
            ProjectsBacker = new List<ProjectBacker>();
            ProjectPages = new List<ProjectPage>();
        }
    }
}
