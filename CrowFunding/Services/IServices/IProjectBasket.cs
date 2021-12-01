using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowFunding.Domain;

namespace CrowFunding.Services.IServices
{
    public interface IProjectBasket
    {
        public ProjectBasket CreateBasket(int userId);

        public ProjectBasket GetBasket(int basketId);
        public decimal GetTotalCost(int basketId);
        public ProjectBasket AddProjectBasket(int basketId, int projectId);
        public bool RemoveProjectBasket(int basketId, int projectId);
    }
}
