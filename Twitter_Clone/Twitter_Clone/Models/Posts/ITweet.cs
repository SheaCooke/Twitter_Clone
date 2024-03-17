using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Clone.Models.Posts
{
    interface ITweet
    {
        int ReTweetPost();
        int Like();
        int Dislike();
        int Report();
        int Hide();
    }
}
