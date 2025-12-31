namespace Xendit.net.Enum
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unknown)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum SubscriptionRecurrenceInterval
    {
        Unknown,

        [EnumMember(Value = "DAY")]
        Day,

        [EnumMember(Value = "WEEK")]
        Week,

        [EnumMember(Value = "MONTH")]
        Month,
    }
}
