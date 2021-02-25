using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Forum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        static private List<userPost> posts = new List<userPost>()
        {
            new userPost(){ID=1, TimeStamp=DateTime.Now, Subject="First!", Message="First Post"},
            new userPost(){ID=2, TimeStamp=DateTime.Now, Subject="Second!", Message="Second Post"},
            new userPost(){ID=3, TimeStamp=DateTime.Now, Subject="Third!", Message="Third Post"}
        };
        
        // GET: api/<ForumController>
        [HttpGet]
        public List<userPost> Get()
        {
            return posts;
        }

        // GET api/<ForumController>/5
        [HttpGet("{id}")]
        public userPost Get(int id)
        {
            return posts.FirstOrDefault(posts => posts.ID == id);
        }

        // GET api/<ForumController>/5
        [HttpGet("Count/{count}")]
        public IEnumerable<userPost> GetCount(int count)
        {
            var recents = posts.OrderByDescending(p =>p.ID).Take(count);
            return recents;
        }

        // POST api/<ForumController>
        [HttpPost]
        public string Post([FromBody] userPost value)
        {
            if (ModelState.IsValid)
            {
                int id;
                if (posts.Count == 0)
                {
                    id = 0;
                }
                {
                    id = posts[posts.Count - 1].ID + 1;
                }
                userPost up = new userPost() { ID = id, TimeStamp = DateTime.Now, Subject = value.Subject, Message = value.Message };
                posts.Add(up);
                return "Post added!";
            }
            else
            {
                return "Failed to add post!";
            }
        }

        // PUT api/<ForumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ForumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
