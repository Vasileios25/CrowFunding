using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public class CrmDbContext : DbContext
    {

        public DbSet<User> User{ get; set; }
        public DbSet<ProjectPage> ProjectPage { get; set; }
        //public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        
        public DbSet<ProjectReward> Rewards { get; set; }
        
        public DbSet<ProjectBasket> ProjectBasket { get; set; }
        public DbSet<ProjectBacker> ProjectBackers { get; set; }




        public CrmDbContext(DbContextOptions options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CrowFunding;User ID=sa;Password=admin!@#123");
        }
    }
}
