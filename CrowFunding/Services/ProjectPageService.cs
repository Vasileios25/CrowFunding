using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowFunding.Domain;
using CrowFunding.Dto;
using CrowFunding.Services;
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

        public async Task<ProjectDto> AddProject(ProjectDto dto)
        {
            User user = await _db.User.SingleOrDefaultAsync(u => u.Id == dto.Id);
            if (user == null) return null;

            ProjectPage project = new ProjectPage()
            {
                Title = dto.Title,
                Video = dto.Video,
                Description = dto.Description,
                Image = dto.Image

            };
            _db.ProjectPage.Add(project);
            await _db.SaveChangesAsync();

            return project.Convert();
        }

       

        public async Task<bool> DeleteProject(int projectId)
        {
            ProjectPage projectpage = _db.ProjectPage.SingleOrDefault
                (pr => pr.Id == projectId);
            if (projectpage == null) return false;
            _db.ProjectPage.Remove(projectpage);

            await _db.SaveChangesAsync();
            return true;

                
        }

        public Task<List<ProjectDto>> GetAllProject()
        {
            throw new NotImplementedException();
        }

        public async Task<ProjectDto> GetProject(int projectId)
        {
           
            var project = await _db.ProjectPage
                .Include(u => u.User)
                .SingleOrDefaultAsync(pr => pr.Id == projectId);

            if (project == null) return null;
            return new ProjectDto()
            {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description,
                Video = project.Video,
                Image = project.Image,
                StatusUpdate = false,
                User = new()
                {
                    FirstName = project.User.FirstName,
                    LastName = project.User.LastName
                }



            };
    }

        public async Task<ProjectDto> Replace(int projectId, ProjectDto dto)
        {
            ProjectPage projectPage = await _db.ProjectPage
                .SingleOrDefaultAsync(pr => pr.Id == projectId);

            if (projectPage is null)
                throw new NotFoundException("The project id is invalid or has been removed.");

            if (projectPage.Image is null)
                throw new NotFoundException
                   ("An image must be specified. To update only specific properties of a project, consider using the PATCH method");
            if (projectPage.Title is null)
                throw new NotFoundException
                  ("A title must be specified. To update only specific properties of a project, consider using the PATCH method");
            if (projectPage.Video is null)
                throw new NotFoundException
                 ("A video must be specified. To update only specific properties of a project, consider using the PATCH method");
            if (projectPage.Description is null)
                throw new NotFoundException
                 ("A description must be specified. To update only specific properties of a project, consider using the PATCH method");

            User user = await _db.User.SingleOrDefaultAsync(u => u.Id == dto.User.Id);

            if (user is null)
                throw new NotFoundException("The user id is invalid or has been removed.");

            projectPage.Title = dto.Title;
            projectPage.Description = dto.Description;
            projectPage.Video = dto.Video;
            projectPage.Image = dto.Image;

            await _db.SaveChangesAsync();

            return projectPage.ConvertUpdate();


        }

        public Task<List<ProjectDto>> Search(string Ttile, string Description, string Image, string Video)
        {
            //var results = _db.ProjectPage.Include(pr => pr.pr)
            return null;
        }

        public async Task<ProjectDto> UpdateProject(int projectId, ProjectDto dto)
        {
            ProjectPage projectPage = await _db.ProjectPage.SingleOrDefaultAsync(pr => pr.Id == projectId);
            if (projectPage is null) throw new NotFoundException("This project id is invalid or has been deleted,please select a diffent id!");

            if (dto.Title != null) projectPage.Title = dto.Title;
            if (dto.Image != null) projectPage.Image = dto.Image;
            if (dto.Video != null) projectPage.Video = dto.Video;
            if (dto.Description != null) projectPage.Description = dto.Description;

            await _db.SaveChangesAsync();

            return projectPage.ConvertUpdate();
            

        }

        
    }

       
    
}
