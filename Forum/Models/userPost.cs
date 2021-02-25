using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class userPost
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
