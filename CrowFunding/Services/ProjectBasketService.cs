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

       

        public async Task<BasketDto> CreateBasket(BasketDto dto)
        {
            User user = await _db.User.SingleOrDefaultAsync(u => u.Id == dto.Id);
            if (user == null) return null;

            ProjectBasket projectBasket = new ProjectBasket()
            {
                DateTime = DateTime.Now,
                TotalPrice = dto.TotalPrice
            };

            _db.ProjectBasket.Add(projectBasket);
            await _db.SaveChangesAsync();

            return projectBasket.ConvertBasket();
        }

        public Task<BasketDto> GetBasket(int basketId)
        {
            throw new NotImplementedException();

        }

        public Task<BasketDto> GetBasket(BasketDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalCost(int basketId)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetTotalCost()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveProjectBasket(int basketId, int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
