﻿namespace Xendit.net.Enum
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    public class LinkedAccountEnum
    {
        [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unknown)]
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public enum ChannelCode
        {
            Unknown,

            [EnumMember(Value = "DC_BRI")]
            DcBri,

            [EnumMember(Value = "BCA_ONEKLIK")]
            BcaOneKlik,

            [EnumMember(Value = "BA_BPI")]
            BaBpi,

            [EnumMember(Value = "BA_UBP")]
            BaUbp,
        }
    }
}