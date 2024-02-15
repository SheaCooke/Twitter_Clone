using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twitter_Clone.Models.Utils;

namespace Twitter_Clone.Models.Posts
{
    public class Tweet : Post, ITweet
    {
        public PrivacySettings privacySettings { get; set; }

        public int NumLikes { get; set; }

        public int NumReTweets { get; set; }

        public int Dislike()
        {
            throw new NotImplementedException();
        }

        public int Hide()
        {
            throw new NotImplementedException();
        }

        public int Like()
        {
            throw new NotImplementedException();
        }

        public int Report()
        {
            throw new NotImplementedException();
        }

        public int reTweet()
        {
            throw new NotImplementedException();
        }
    }
}