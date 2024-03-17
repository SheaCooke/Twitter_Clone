using NUnit.Framework;
using Twitter_Clone.Models.Posts;

namespace Twitter_Clone_Test
{
    public class TweetTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TweetProperlyInitialized()
        {
            Tweet tweet = new Tweet();
            Assert.AreEqual(tweet.NumLikes, 0);
            Assert.AreEqual(tweet.NumReTweets, 0);
            Assert.AreEqual(tweet.NumDisLikes, 0);
        }

        [Test]
        public void ReTweetRunsSuccessfully()
        {
            Tweet tweet = new Tweet();
            Assert.AreEqual(tweet.ReTweetPost(), 1);
            Assert.AreEqual(tweet.NumReTweets, 1);
        }

        [Test]
        public void LikeRecorded()
        {
            Tweet tweet = new Tweet();
            tweet.Like();
            Assert.AreEqual(tweet.NumLikes, 1);
        }

        [Test]
        public void DislikeRecorded()
        {
            Tweet tweet = new Tweet();
            tweet.Dislike();
            Assert.AreEqual(tweet.NumDisLikes, 1);
        }
    }
}