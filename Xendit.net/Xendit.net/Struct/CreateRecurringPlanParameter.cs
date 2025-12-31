namespace Xendit.net.Struct
{
    using System.Text.Json.Serialization;

    public struct CreateRecurringPlanParameter
    {
        [JsonPropertyName("reference_id")]
        public string ReferenceId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonPropertyName("interval_count")]
        public int? IntervalCount { get; set; }

        [JsonPropertyName("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        [JsonPropertyName("metadata")]
        public System.Collections.Generic.Dictionary<string, object> Metadata { get; set; }
    }
}
