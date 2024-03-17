using NUnit.Framework;
using Twitter_Clone.Models.Posts;

namespace Twitter_Clone_Test
{
    class ReTweetTests
    {
        [Test]
        public void ReTweetProperlyInitialized()
        {
            ReTweet retweet = new ReTweet();
            Assert.AreEqual(retweet.NumLikes, 0);
            Assert.AreEqual(retweet.NumReTweets, 0);
            Assert.AreEqual(retweet.NumDisLikes, 0);
        }
    }
}
