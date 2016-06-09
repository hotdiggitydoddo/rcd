using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RCDWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        private RCDContext _context;

        public PostsController(RCDContext context) 
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            var posts = _context.Posts.ToList();
            return posts;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            var post = _context.Posts.SingleOrDefault(x => x.Id == id);
            return post;
        }

        // POST api/values
        [HttpPost]
        public void Post(string title)
        {
            _context.Posts.Add(new Post { Title = title });
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
