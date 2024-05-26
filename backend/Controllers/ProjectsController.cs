using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyAspNetCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProjects()
        {
            var projects = new List<object>
            {
                new { Id = 1, Name = "Project 1", Description = "Description for project 1" },
                new { Id = 2, Name = "Project 2", Description = "Description for project 2" }
            };

            return Ok(projects);
        }
    }
}
