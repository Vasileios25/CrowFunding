using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowFunding.Domain;
using CrowFunding.Dto;

namespace CrowFunding.Services.IServices
{
    public interface IProjectBasket
    {
        public Task<BasketDto> CreateBasket(BasketDto dto);

        public Task<BasketDto> GetBasket(BasketDto dto);
        public Task<decimal> GetTotalCost(BasketDto dto);
        public Task<BasketDto> AddProject2Basket(int basketId, int projectId);
        public Task<bool> RemoveProjectBasket(int basketId, int projectId);
    }
}
