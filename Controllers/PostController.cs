using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheJourneyAPI.Data;
using TheJourneyAPI.Models;

namespace TheJourneyAPI.Controllers
{
    [ApiController]
    [Route("TheJourney")]
    public class PostController : ControllerBase
    {

        private readonly DataContext _context;

        public PostController(DataContext context)
        {
            _context = context;
        }





        [HttpGet("allPosts")]
        public async Task<ActionResult<List<Posts>>> GetAllPosts()
        {
            var posts =  await _context.posts.ToListAsync();

            return Ok(posts);
        }
         
        [HttpGet("post/{id}")]
        public async Task<ActionResult<List<Posts>>> GetPost(int id)
        {
            var post = await _context.posts.FindAsync(id);
            if(post is null)
                return BadRequest("Post not found.");

            return Ok(post);
        }


        [HttpGet("Comments")]
        public async Task<ActionResult<List<Comments>>> GetAllComments()
        {
            var comments =  await _context.comments.ToListAsync();

            return Ok(comments);
        }
        [HttpGet("Comment/{ParentPost}")]
        public async Task<ActionResult<List<Comments>>> GetComment(int ParentPost)
        {
            var comment = _context.comments.Where(comment => comment.ParentPost == ParentPost).ToList();   
            if (comment is null)
                return BadRequest("Post not found.");


            return Ok(comment);
        }

        [HttpPost("newPost")]
        public async Task<ActionResult<List<Posts>>> AddPost(Posts post)
        {
            _context.posts.Add(post);
            await _context.SaveChangesAsync();

            return Ok(await _context.posts.ToListAsync());
        }

        [HttpPost("newComment")]
        public async Task<ActionResult<List<Posts>>> AddComment(Comments comment)
        {
            _context.comments.Add(comment);
            await _context.SaveChangesAsync();

            return Ok(await _context.comments.ToListAsync());
        }
    }
}