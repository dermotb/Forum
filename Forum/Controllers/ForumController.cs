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

        // POST api/<ForumController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
