using CrowFunding.Dto;
using CrowFunding.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowFunding.Services;

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
        [HttpGet]
        public async Task<List<ProjectDto>> Get()
        {
            return await projectPageService.GetAllProject();
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<ProjectDto>> GetProjectById(int id)
        {
            var dto = await projectPageService.GetProject(id);
            if (dto == null) return NotFound("The project is is worng or this project has been removed");
            return Ok(dto);
        }

        [HttpGet, Route("Search")]
        public ActionResult<List<ProjectDto>> Search (string title, string description)
        {
            return null;
        }

        [HttpPost]
        public async Task<ActionResult<ProjectDto>> Post(ProjectDto dto)
        {
            ProjectDto result = await projectPageService.AddProject(dto);
            if (result == null) return NotFound("The specified project Id is invalid or the project has been removed. Could not create project.");
            return View();
        }

        [HttpPatch, Route("{id}")]
        public async Task<ActionResult<ProjectDto>> Patch([FromRoute] int id, [FromBody] ProjectDto dto)
        {
            try
            {
                var response = await projectPageService.UpdateProject(id, dto);
                return Ok(response);
            }

            catch (AggregateException e)
            {
                foreach (var exception in e.InnerExceptions)
                {
                    if (exception is NotFoundException)
                        return BadRequest("Could not find the project. Ensure the project id is correct and try again.");
                }
            }

            return StatusCode(500);
        }

        [HttpPut, Route("{id}")]
        public async Task<ActionResult<ProjectDto>> Put([FromRoute] int id, [FromBody] ProjectDto dto)
        {
            try
            {
                var response = await projectPageService.Replace(id, dto);
                return Ok(response);
            }

            catch (AggregateException e)
            {
                foreach (var exception in e.InnerExceptions)
                {
                    if (exception is NotFoundException)
                        return BadRequest(e.Message);
                }
            }

            return StatusCode(500);
        }
        [HttpDelete, Route("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            await projectPageService.DeleteProject(id);
            return RedirectToAction(nameof(Index));

        }
    }


}





