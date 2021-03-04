using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicBit.Core.Interfaces;
using MusicBit.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository; 

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPost() 
        {
            var post = await _postRepository.GetPosts();
            return Ok(post);
        }
    }
}
