namespace Xendit.net.Model.Subscription
{
    using System.Text.Json.Serialization;
    using Xendit.net.Enum;

    public class SubscriptionCycle
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        [JsonPropertyName("status")]
        public SubscriptionCycleStatus Status { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }
    }
}
