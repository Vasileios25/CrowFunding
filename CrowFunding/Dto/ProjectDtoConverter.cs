using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrowFunding.Domain;

namespace CrowFunding.Dto
{
    public static class ProjectDtoConverter
    {

        public static ProjectDto Convert(this ProjectPage project)
        {
            return new ProjectDto()
            {
                Id = project.Id,
                Title = project.Title,
                Video = project.Video,
                Description = project.Description,
                User = new()
                {
                    Id = project.User.Id,
                    FirstName = project.User.FirstName,
                    LastName = project.User.LastName
                }
            };
        }
        public static ProjectDto ConvertUpdate(this ProjectPage project)
        {
            return new ProjectDto()
            {
                Id = project.Id,
                Title = project.Title,
                Video = project.Video,
                Description = project.Description,
                StatusUpdate = true,
                User = new()
                {
                    Id = project.User.Id,
                    FirstName = project.User.FirstName,
                    LastName = project.User.LastName
                }
            };
        }

            public static BasketDto ConvertBasket(this ProjectBasket projectBasket)
            {
            return new BasketDto()
            {
                Id = projectBasket.Id,
                DateTime = projectBasket.DateTime,
                TotalPrice = projectBasket.TotalPrice,




            };
            }

            public static UserDto Convert(this User user)
            {
                var result = new UserDto()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password
                };

                if (user.ProjectPages is not null)
                {
                    result.Projects = user.ProjectPages.Select(b => b.Convert()).ToList();
                }

                return result;

        }

        }
    
}
