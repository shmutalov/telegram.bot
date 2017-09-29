﻿using Newtonsoft.Json;

namespace Telegram.Bot4.Types
{
    /// <summary>
    /// This object represents an audio file to be treated as music by the Telegram clients.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Audio : File
    {
        /// <summary>
        /// Duration of the audio in seconds as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "duration", Required = Required.Always)]
        public int Duration { get; set; }

        /// <summary>
        /// Performer of the audio as defined by sender or by audio tags
        /// </summary>
        [JsonProperty(PropertyName = "performer", Required = Required.Default)]
        public string Performer { get; set; }

        /// <summary>
        /// Title of the audio as defined by sender or by audio tags
        /// </summary>
        [JsonProperty(PropertyName = "title", Required = Required.Default)]
        public string Title { get; set; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "mime_type", Required = Required.Default)]
        public string MimeType { get; set; }
    }
}
