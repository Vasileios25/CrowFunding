using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowFunding.Domain;
using CrowFunding.Dto;
using Microsoft.EntityFrameworkCore;

namespace CrowFunding.Service
{
    public class ProjectPageService : IProjectPageService
    {
        private readonly CrmDbContext _db;

        public ProjectPageService(CrmDbContext aproject)
        {
            _db = aproject;
        }

        public Task<ProjectDto> AddProject(int projectId, ProjectDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<ProjectDto> CreateProject(ProjectDto dto)
        {
            return await null;
        }

        public Task<ProjectDto> DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<ProjectDto> GetProject(int projectId)
        {
            //false why??//var project = await _db.ProjectPage.FindAsync(projectId);
            var project = await _db.ProjectPage
                .Include(u => u.User)
                .SingleOrDefaultAsync(pr => pr.Id == projectId);

            if (project == null) return null;
            return new ProjectDto()
            {
                Id = project.Id,
                Title = project.Title,
                User = new()
                {
                    FirstName = project.User.FirstName,
                    LastName = project.User.LastName
                }



            };
    }
        public Task<ProjectUpdateDto> UpdateProject(int projectId, ProjectDto dto)
        {
            throw new NotImplementedException();
        }
    }

       
    }
}
