﻿using Newtonsoft.Json;

namespace Telegram.Bot4.Types.Payments
{
    /// <summary>
    /// This object represents a shipping address.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ShippingAddress
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code
        /// </summary>
        [JsonProperty("country_code", Required = Required.Always)]
        public string CountryCode { get; set; }

        /// <summary>
        /// State, if applicable
        /// </summary>
        [JsonProperty("state", Required = Required.Default)]
        public string State { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city", Required = Required.Always)]
        public string City { get; set; }

        /// <summary>
        /// First line for the address
        /// </summary>
        [JsonProperty("street_line1", Required = Required.Always)]
        public string StreetLine1 { get; set; }

        /// <summary>
        /// Second line for the address
        /// </summary>
        [JsonProperty("street_line2", Required = Required.Always)]
        public string StreetLine2 { get; set; }

        /// <summary>
        /// Address post code
        /// </summary>
        [JsonProperty("post_code", Required = Required.Always)]
        public string PostCode { get; set; }
    }
}
