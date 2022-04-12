using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public int tweetId { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
    }
}
