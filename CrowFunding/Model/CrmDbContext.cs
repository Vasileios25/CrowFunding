using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Model
{
    public class CrmDbContext : DbContext
    {











        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=RegenCrm2;User ID=sa;Password=admin!@#123");
        }
    }
}
