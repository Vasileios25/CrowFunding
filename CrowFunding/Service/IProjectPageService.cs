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
        public Task<ProjectCreateDto> CreateProject(ProjectCreateDto dto);
    }
      

    
}
