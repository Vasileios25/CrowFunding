using CrowFunding.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrowFunding.Service
{
    public interface IProjectPageService
    {
        public Task<ProjectDto> AddProject( ProjectDto dto);
        public Task<ProjectDto> UpdateProject(int projectId, ProjectDto dto);
        public Task<bool> DeleteProject(int projectId);
        public Task<ProjectDto> GetProject(int projectId);
        public Task<List<ProjectDto>> GetAllProject();
        public Task<ProjectDto> Replace(int projectid, ProjectDto dto);
        public Task<List<ProjectDto>> Search
            (string Ttile, string Description, string Image, string Video);
    }
      

    
}
