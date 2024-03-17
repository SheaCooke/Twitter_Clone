using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Clone.Models.Posts
{
    public abstract class Post
    {      
        int TweetId { get; set; }

        DateTime PostDate { get; set; }

        int UserID { get; set; }

        String Content { get; set; }

    }
}
