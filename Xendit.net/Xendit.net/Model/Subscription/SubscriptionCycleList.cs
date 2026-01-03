namespace Xendit.net.Model.Subscription
{
    using System.Text.Json.Serialization;

    public class SubscriptionCycleList
    {
        [JsonPropertyName("data")]
        public SubscriptionCycle[] Data { get; set; }

        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
