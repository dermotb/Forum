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

        [MinLength(1)]
        [MaxLength(25)]
        public string Subject { get; set; }
        [MinLength(1)]
        [MaxLength(100)]
        public string Message { get; set; }

        public userPost(int _id, string _subj, string _msg)
        {
            ID = _id;
            Subject = _subj;
            Message = _subj;
        }

        public userPost()
        { }
    }
}
