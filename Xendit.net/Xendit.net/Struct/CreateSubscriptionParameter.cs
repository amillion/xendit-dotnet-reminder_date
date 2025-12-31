namespace Xendit.net.Struct
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Xendit.net.Enum;

    public struct CreateSubscriptionParameter
    {
        [JsonPropertyName("reference_id")]
        public string ReferenceId { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("recurring_action")]
        public SubscriptionRecurringAction RecurringAction { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("schedule")]
        public ScheduleParameter Schedule { get; set; }

        [JsonPropertyName("payment_methods")]
        public PaymentMethodEntry[] PaymentMethods { get; set; }

        [JsonPropertyName("immediate_action_type")]
        public SubscriptionImmediateActionType ImmediateActionType { get; set; }

        [JsonPropertyName("notification_config")]
        public NotificationConfigParameter NotificationConfig { get; set; }

        [JsonPropertyName("payment_link_for_failed_attempt")]
        public bool? PaymentLinkForFailedAttempt { get; set; }

        [JsonPropertyName("failed_cycle_action")]
        public SubscriptionFailedCycleAction FailedCycleAction { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("items")]
        public ItemParameter[] Items { get; set; }

        [JsonPropertyName("success_return_url")]
        public string SuccessReturnUrl { get; set; }

        [JsonPropertyName("failure_return_url")]
        public string FailureReturnUrl { get; set; }

        public struct PaymentMethodEntry
        {
            [JsonPropertyName("payment_method_id")]
            public string PaymentMethodId { get; set; }

            [JsonPropertyName("rank")]
            public int? Rank { get; set; }
        }

        public struct NotificationConfigParameter
        {
            [JsonPropertyName("recurring_created")]
            public SubscriptionNotificationChannel[] RecurringCreated { get; set; }

            [JsonPropertyName("recurring_succeeded")]
            public SubscriptionNotificationChannel[] RecurringSucceeded { get; set; }

            [JsonPropertyName("recurring_failed")]
            public SubscriptionNotificationChannel[] RecurringFailed { get; set; }

            [JsonPropertyName("locale")]
            public SubscriptionLocale Locale { get; set; }
        }

        public struct ItemParameter
        {
            [JsonPropertyName("type")]
            public SubscriptionItemType Type { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("net_unit_amount")]
            public decimal NetUnitAmount { get; set; }

            [JsonPropertyName("quantity")]
            public int Quantity { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonPropertyName("category")]
            public string Category { get; set; }

            [JsonPropertyName("subcategory")]
            public string Subcategory { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("metadata")]
            public Dictionary<string, object> Metadata { get; set; }
        }

        public struct ScheduleParameter
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("reference_id")]
            public string ReferenceId { get; set; }

            [JsonPropertyName("business_id")]
            public string BusinessId { get; set; }

            [JsonPropertyName("interval")]
            public SubscriptionRecurrenceInterval Interval { get; set; }

            [JsonPropertyName("interval_count")]
            public int? IntervalCount { get; set; }

            [JsonPropertyName("total_recurrence")]
            public int? TotalRecurrence { get; set; }

            [JsonPropertyName("anchor_date")]
            public DateTimeOffset? AnchorDate { get; set; }

            [JsonPropertyName("retry_interval")]
            public SubscriptionRetryInterval RetryInterval { get; set; }

            [JsonPropertyName("retry_interval_count")]
            public int? RetryIntervalCount { get; set; }

            [JsonPropertyName("total_retry")]
            public int? TotalRetry { get; set; }

            [JsonPropertyName("failed_attempt_notifications")]
            public int[] FailedAttemptNotifications { get; set; }

            [JsonPropertyName("created")]
            public DateTimeOffset? Created { get; set; }

            [JsonPropertyName("updated")]
            public DateTimeOffset? Updated { get; set; }
        }
    }
}
