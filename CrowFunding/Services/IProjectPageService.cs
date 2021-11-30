using CrowFunding.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowFunding.Dto;
namespace CrowFunding.Service
{
    public interface IProjectPageService
    {
        public Task<ProjectDto> AddProject(int projectId, ProjectDto dto);
        public Task<ProjectUpdateDto> UpdateProject(int projectId, ProjectDto dto);
        public Task<ProjectDto> DeleteProject(int projectId);
        public Task<ProjectDto> GetProject(int projectId);
    }
      

    
}
