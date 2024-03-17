using Microsoft.Extensions.Logging;
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

        //TODO: can these be private?
        public int NumLikes { get; set; }

        public int NumDisLikes { get; set; }

        public int NumReTweets { get; set; }

        public int Dislike()
        {
            this.NumDisLikes++;
            return 1;
        }

        public int Hide()
        {
            throw new NotImplementedException();
        }

        public int Like()
        {
            this.NumLikes++;
            return 1;
        }

        public int Report()
        {
            throw new NotImplementedException();
        }

        public int ReTweetPost()
        {
            this.NumReTweets++;
            return 1;
        }

        public Tweet()
        {
            //TODO: way to set this by default
            this.NumDisLikes = 0;
            this.NumLikes = 0;
            this.NumReTweets = 0;
        }
    }
}