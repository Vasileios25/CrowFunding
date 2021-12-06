using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic
namespace CrowFunding.Domain
{
    public class ProjectPage
    {
        public int Id { get; set; }
        [MaxLength(50)][Required]
        public string Title {get; set;}
        [MaxLength(200)]
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        //public bool StatusUpdate { get; set; }
        public DateTime DueDate { get; set; }
        public int CurrentAmount { get; set; }
        public int TotalBackers { get; set; }
        public int GoalAmount { get; set; }
        public DateTime DateInserted { get; set; }

        public int ProjectCategoryId { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }
        public int StatusId { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }
        public virtual User User { get; set; } = new();
        public int BasketId { get; set; }

        //private ICollection<T> category { get; set; }

       /* public virtual icollection<t> getcategory()
        {
            return category;
        }

        public virtual void SetCategory(ICollection<T> value)
        {
            category = value;
        }*/

        public virtual ICollection<ProjectReward> Reward { get; set; }
        public virtual ICollection<ProjectBacker> ProjectBacker { get; set; }
        public ProjectPage()
        {
            ProjectBacker = new List<ProjectBacker>();
            Reward = new List<ProjectReward>();
            
        }
    }
}
