using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twitter_Clone.Models.Utils
{
    public class PrivacySettings
    {
        public enum PrivacySettingOptions
        {
            FollowersOnly,
            Public
        }

        public PrivacySettingOptions privacySettingOption { get; set; }
    }
}