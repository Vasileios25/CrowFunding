using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowFundingMvc.Models
{
    public class UserAccountDb : DbContext
    {

        public DbSet<UserAccount> userAccount { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CrowFunding;User ID=sa;Password=admin!@#123");
        }
    }
}
