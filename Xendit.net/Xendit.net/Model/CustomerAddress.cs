﻿namespace Xendit.net.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    public class CustomerAddress
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("street_line1")]
        public string StreetLine1 { get; set; }

        [JsonPropertyName("street_line2")]
        public string StreetLine2 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("province")]
        public string Province { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }
    }
}
