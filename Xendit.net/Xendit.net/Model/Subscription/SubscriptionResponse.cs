namespace Xendit.net.Model.Subscription
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Xendit.net.Enum;
    using static Xendit.net.Struct.CreateSubscriptionParameter;

    public class SubscriptionResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("reference_id")]
        public string ReferenceId { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("recurring_action")]
        public SubscriptionRecurringAction RecurringAction { get; set; }

        [JsonPropertyName("failed_cycle_action")]
        public SubscriptionFailedCycleAction FailedCycleAction { get; set; }

        [JsonPropertyName("recurring_cycle_count")]
        public int RecurringCycleCount { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("created")]
        public DateTimeOffset? Created { get; set; }

        [JsonPropertyName("updated")]
        public DateTimeOffset? Updated { get; set; }

        [JsonPropertyName("schedule_id")]
        public string ScheduleId { get; set; }

        [JsonPropertyName("payment_methods")]
        public PaymentMethodEntry[] PaymentMethods { get; set; }

        [JsonPropertyName("schedule")]
        public ScheduleParameter Schedule { get; set; }

        [JsonPropertyName("immediate_action_type")]
        public SubscriptionImmediateActionType ImmediateActionType { get; set; }

        [JsonPropertyName("notification_config")]
        public NotificationConfigParameter NotificationConfig { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("actions")]
        public ActionResponse[] Actions { get; set; }

        [JsonPropertyName("success_return_url")]
        public string SuccessReturnUrl { get; set; }

        [JsonPropertyName("failure_return_url")]
        public string FailureReturnUrl { get; set; }

        [JsonPropertyName("items")]
        public ItemParameter[] Items { get; set; }

        [JsonPropertyName("payment_link_for_failed_attempt")]
        public bool PaymentLinkForFailedAttempt { get; set; }

        [JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        public class ActionResponse
        {
            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonPropertyName("action")]
            public string Action { get; set; }

            [JsonPropertyName("method")]
            public string Method { get; set; }

            [JsonPropertyName("url_type")]
            public string UrlType { get; set; }
        }
    }
}
