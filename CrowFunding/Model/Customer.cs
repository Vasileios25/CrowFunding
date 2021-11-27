using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Model
{
    public abstract class Users
    {


        public int Id { get; set; }
        [MaxLength(50)][Required]
        public string FirstName { get; set; }
        [MaxLength(50)][Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public  string Password  { get; set; }
    }
}
