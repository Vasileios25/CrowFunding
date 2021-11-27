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

        public DbSet<Bucker> Buckers { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Project> Projects { get; set; }
        //public DbSet<ProjectCategory> ProjectCategory { get; set; }

        public DbSet<Profile> Profile { get; set; }
        public DbSet<Basket> Basket { get; set; }








        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CrowFunding;User ID=sa;Password=admin!@#123");
        }
    }
}
