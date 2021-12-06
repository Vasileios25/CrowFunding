using CrowFunding.Domain;
using CrowFunding.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Services.IServices
{
    public interface IProjectBackerService
    {
        public Task<ProjectBackerDto> BrowseByCategory(ProjectBackerDto dto);
        public Task<ProjectBackerDto> BrowseByText(ProjectBackerDto dto);
        public Task<ProjectBackerDto> BackProject(int projectId, ProjectBackerDto dto);
        public Task<ProjectBackerDto> ViewBackProjects(int projectId);













    }
}
