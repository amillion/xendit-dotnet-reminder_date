namespace Xendit.net.Enum
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unknown)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum SubscriptionImmediateActionType
    {
        Unknown,

        [EnumMember(Value = "FULL_AMOUNT")]
        FullAmount,
    }
}
