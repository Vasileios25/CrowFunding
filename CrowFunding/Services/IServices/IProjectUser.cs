using CrowFunding.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Services.IServices
{
    public interface IProjectUser
    {
        public Task<UserDto> GetUser(int id, bool includeProjects);
        public Task<List<UserDto>> GetAllUser(bool includeProjects);
        
        public Task<List<UserDto>> Search(string firstName, string lastName, bool includeProjects);
        public Task<UserDto> Update(int userId, UserDto dto);
        public Task<UserDto> Replace(int projectId, UserDto dto);
        public Task<bool> Delete(int id);

    }
}
