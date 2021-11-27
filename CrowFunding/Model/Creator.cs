using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Model
{
    public class Creator : Users
    {
        public string Project { get; set; }
        public Creator (string aEmail, string aFirstName, string aLastName, string aPassword)
        {
            FirstName = aFirstName;
            LastName = aLastName;
            Email = aEmail;
            Password = aPassword;
        }
    }
}
