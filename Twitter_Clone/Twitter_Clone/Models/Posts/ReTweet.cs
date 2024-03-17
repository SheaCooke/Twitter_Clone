using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twitter_Clone.Models.Posts
{
    public class ReTweet : Tweet
    {
        public int BaseTweetId { get; set; }

        public int ReTweeterId { get; set; }

        public ReTweet() : base() { }
    }
}