﻿using Newtonsoft.Json;

namespace Telegram.Bot4.Types
{
    /// <summary>
    /// This object represent a user's profile pictures.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class UserProfilePhotos
    {
        /// <summary>
        /// Total number of profile pictures the target user has
        /// </summary>
        [JsonProperty(PropertyName = "total_count", Required = Required.Always)]
        public int TotalCount { get; set; }

        //TODO: FIX Array of Array
        /// <summary>
        /// Requested profile pictures (in up to 4 sizes each)
        /// </summary>
        [JsonProperty(PropertyName = "photos", Required = Required.Always)]
        public PhotoSize[][] Photos { get; set; }
    }
}
