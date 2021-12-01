using CrowFunding.Domain;
using CrowFunding.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Service
{
    public class ProjectBasketService : IProjectBasket
    {
        private readonly CrmDbContext _db;

        public ProjectBasketService(CrmDbContext aproject)
        {
            _db = aproject;
        }
        public ProjectBasket AddProjectBasket(int basketId, int projectId)
        {
            throw new NotImplementedException();
        }

        public ProjectBasket CreateBasket(int userId)
        {
            throw new NotImplementedException();
        }

        public ProjectBasket GetBasket(int basketId)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalCost(int basketId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProjectBasket(int basketId, int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
