namespace Xendit.net.Enum
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unknown)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum SubscriptionItemType
    {
        Unknown,

        [EnumMember(Value = "DIGITAL_PRODUCT")]
        DigitalProduct,

        [EnumMember(Value = "PHYSICAL_PRODUCT")]
        PhysicalProduct,

        [EnumMember(Value = "DIGITAL_SERVICE")]
        DigitalService,

        [EnumMember(Value = "PHYSICAL_SERVICE")]
        PhysicalService,

        [EnumMember(Value = "FEE")]
        Fee,

        [EnumMember(Value = "DISCOUNT")]
        Discount,
    }
}
