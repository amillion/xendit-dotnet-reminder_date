namespace Xendit.net.Model.Subscription
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Xendit.net.Network;
    using Xendit.net.Struct;

    public class SubscriptionClient : BaseClient
    {
        public SubscriptionClient(string apiKey = null, INetworkClient requestClient = null, string baseUrl = null)
            : base(apiKey, requestClient, baseUrl)
        {
        }

        /// <summary>
        /// Create a subscription (recurring plan).
        /// </summary>
        public async Task<SubscriptionResponse> Create(CreateSubscriptionParameter parameter, HeaderParameter? headers = null)
        {
            // Validate description length to match API limit
            if (parameter.Description != null && parameter.Description.Length > 1000)
            {
                throw new System.ArgumentException("Description cannot be longer than 1000 characters", nameof(parameter.Description));
            }

            string url = "/recurring/plans";
            var client = this.requestClient ?? XenditConfiguration.RequestClient;
            return await client.Request<CreateSubscriptionParameter, SubscriptionResponse>(HttpMethod.Post, url, this.ApiKey, this.BaseUrl, parameter, headers);
        }

        /// <summary>
        /// Get a recurring plan by id.
        /// </summary>
        public async Task<SubscriptionResponse> Get(string id, HeaderParameter? headers = null)
        {
            string url = string.Format("{0}{1}{2}", "/recurring/plans/", id, "/");
            var client = this.requestClient ?? XenditConfiguration.RequestClient;
            return await client.Request<SubscriptionResponse>(HttpMethod.Get, url, this.ApiKey, this.BaseUrl, headers);
        }

        /// <summary>
        /// Deactivate a recurring plan by id.
        /// </summary>
        public async Task<SubscriptionResponse> Deactivate(string id, HeaderParameter? headers = null)
        {
            string url = string.Format("{0}{1}{2}", "/recurring/plans/", id, "/deactivate");
            var client = this.requestClient ?? XenditConfiguration.RequestClient;
            return await client.Request<Dictionary<string, string>, SubscriptionResponse>(HttpMethod.Post, url, this.ApiKey, this.BaseUrl, new Dictionary<string, string>(), headers);
        }

        /// <summary>
        /// Get recurring cycles for a plan.
        /// </summary>
        public async Task<SubscriptionCycle[]> GetCycles(string planId, HeaderParameter? headers = null)
        {
            string url = string.Format("{0}{1}{2}", "/recurring/plans/", planId, "/cycles");
            var client = this.requestClient ?? XenditConfiguration.RequestClient;
            return await client.Request<SubscriptionCycle[]>(HttpMethod.Get, url, this.ApiKey, this.BaseUrl, headers);
        }

        /// <summary>
        /// Force an attempt for a specific recurring cycle.
        /// </summary>
        public async Task<SubscriptionCycle> ForceAttempt(string planId, string cycleId, HeaderParameter? headers = null)
        {
            string url = string.Format("{0}{1}{2}{3}{4}", "/recurring/plans/", planId, "/cycles/", cycleId, "/force_attempt");
            var client = this.requestClient ?? XenditConfiguration.RequestClient;
            return await client.Request<Dictionary<string, string>, SubscriptionCycle>(HttpMethod.Post, url, this.ApiKey, this.BaseUrl, new Dictionary<string, string>(), headers);
        }

        /// <summary>
        /// Simulate a cycle payment (test mode only).
        /// </summary>
        public async Task<SubscriptionCycle> SimulateCycle(string planId, string cycleId, HeaderParameter? headers = null)
        {
            string url = string.Format("{0}{1}{2}{3}{4}", "/recurring/plans/", planId, "/cycles/", cycleId, "/simulate");
            var client = this.requestClient ?? XenditConfiguration.RequestClient;
            return await client.Request<Dictionary<string, string>, SubscriptionCycle>(HttpMethod.Post, url, this.ApiKey, this.BaseUrl, new Dictionary<string, string>(), headers);
        }
    }
}
