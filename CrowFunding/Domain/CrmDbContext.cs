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
        public DbSet<ProjectTrending> ProjectTrendings { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        
        public DbSet<ProjectBasket> ProjectBasket { get; set; }
        public DbSet<ProjectBacker> ProjectBackers { get; set; }







        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CrowFunding;User ID=sa;Password=admin!@#123");
        }
    }
}
