using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyAspNetCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBlogPosts()
        {
            var blogPosts = new List<object>
            {
                new { Id = 1, Title = "Blog Post 1", Content = "Content for blog post 1" },
                new { Id = 2, Title = "Blog Post 2", Content = "Content for blog post 2" }
            };

            return Ok(blogPosts);
        }
    }
}
