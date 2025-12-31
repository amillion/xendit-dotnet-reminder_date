namespace Xendit.net.Enum
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unknown)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum SubscriptionFailedCycleAction
    {
        Unknown,

        [EnumMember(Value = "RESUME")]
        Resume,

        [EnumMember(Value = "STOP")]
        Stop,
    }
}
