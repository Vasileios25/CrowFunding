using CrowFunding.Dto;
using CrowFunding.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowFundingMvc.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectPageService projectPageService;

        public ProjectController(IProjectPageService aprojectPageService)
        {
            projectPageService = aprojectPageService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet, Route("{id}")]
        public async Task<ActionResult<ProjectDto>> GetProjectById(int id)
        {
            var dto = await projectPageService.GetProject(id);
            if (dto == null) return NotFound("The project is is worng or this project has been removed");
            return Ok(dto);
        }
    }
}
