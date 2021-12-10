using CrowFunding.Domain;
using CrowFunding.Dto;
using CrowFunding.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CrowFunding.Service
{
    public class ProjectBasketService : IProjectBasket
    {
        private readonly CrmDbContext _db;

        public ProjectBasketService(CrmDbContext aproject)
        {
            _db = aproject;
        }

        public Task<BasketDto> AddProject2Basket(int basketId, int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<BasketDto> CreateBasket(BasketDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<BasketDto> GetBasket(BasketDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalCost(BasketDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveProjectBasket(int basketId, int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
