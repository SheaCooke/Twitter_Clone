using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twitter_Clone.Models.Posts
{
    public class Comment : Post
    {
        public int CommentId { get; set; }

        public int CommentersId { get; set; }
    }
}