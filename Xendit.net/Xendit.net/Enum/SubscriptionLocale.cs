namespace Xendit.net.Enum
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unknown)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum SubscriptionLocale
    {
        Unknown,

        [EnumMember(Value = "en")]
        En,

        [EnumMember(Value = "id")]
        Id,
    }
}
