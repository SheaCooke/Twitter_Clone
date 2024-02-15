using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twitter_Clone.Models.Posts
{
    public class ReTweer : Tweet, ITweet
    {
        public int BaseTweetId { get; set; }

        public int ReTweeterId { get; set; }

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