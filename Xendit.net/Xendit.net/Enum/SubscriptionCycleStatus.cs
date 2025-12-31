namespace Xendit.net.Enum
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unknown)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum SubscriptionCycleStatus
    {
        Unknown,

        [EnumMember(Value = "PENDING")]
        Pending,

        [EnumMember(Value = "RETRYING")]
        Retrying,

        [EnumMember(Value = "FAILED")]
        Failed,

        [EnumMember(Value = "SUCCEEDED")]
        Succeeded,
    }
}
