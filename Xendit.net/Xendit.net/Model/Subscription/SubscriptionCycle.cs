namespace Xendit.net.Model.Subscription
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Xendit.net.Enum;

    public class SubscriptionCycle
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("created")]
        public DateTimeOffset? Created { get; set; }

        [JsonPropertyName("updated")]
        public DateTimeOffset? Updated { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("reference_id")]
        public string ReferenceId { get; set; }

        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("recurring_action")]
        public SubscriptionRecurringAction RecurringAction { get; set; }

        [JsonPropertyName("attempt_count")]
        public int AttemptCount { get; set; }

        [JsonPropertyName("cycle_number")]
        public int CycleNumber { get; set; }

        [JsonPropertyName("attempt_details")]
        public AttemptDetail[] AttemptDetails { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonIgnore]
        public SubscriptionCycleStatus StatusEnum
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.Status))
                {
                    return SubscriptionCycleStatus.Unknown;
                }

                switch (this.Status.ToUpperInvariant())
                {
                    case "PENDING":
                        return SubscriptionCycleStatus.Pending;
                    case "RETRYING":
                        return SubscriptionCycleStatus.Retrying;
                    case "FAILED":
                        return SubscriptionCycleStatus.Failed;
                    case "SUCCEEDED":
                        return SubscriptionCycleStatus.Succeeded;
                    case "CANCELED":
                        return SubscriptionCycleStatus.Canceled;
                    default:
                        return SubscriptionCycleStatus.Unknown;
                }
            }
        }

        [JsonPropertyName("scheduled_timestamp")]
        public DateTimeOffset? ScheduledTimestamp { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("forced_attempt_count")]
        public int ForcedAttemptCount { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; }

        public class AttemptDetail
        {
            [JsonPropertyName("created")]
            public DateTimeOffset? Created { get; set; }

            [JsonPropertyName("action_id")]
            public string ActionId { get; set; }

            [JsonPropertyName("status")]
            public string Status { get; set; }

            [JsonPropertyName("failure_code")]
            public string FailureCode { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("attempt_number")]
            public int AttemptNumber { get; set; }

            [JsonPropertyName("action_number")]
            public int ActionNumber { get; set; }

            [JsonPropertyName("next_retry_timestamp")]
            public DateTimeOffset? NextRetryTimestamp { get; set; }

            [JsonPropertyName("payment_link")]
            public string PaymentLink { get; set; }
        }
    }
}
