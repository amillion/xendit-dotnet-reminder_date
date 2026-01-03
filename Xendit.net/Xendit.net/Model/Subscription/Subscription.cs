namespace Xendit.net.Model.Subscription
{
    using System.Threading.Tasks;
    using Xendit.net.Struct;

    public class Subscription
    {
        public static async Task<SubscriptionResponse> Create(CreateSubscriptionParameter parameter, HeaderParameter? headers = null)
        {
            SubscriptionClient client = new SubscriptionClient();
            return await client.Create(parameter, headers);
        }

        public static async Task<SubscriptionResponse> Get(string id, HeaderParameter? headers = null)
        {
            SubscriptionClient client = new SubscriptionClient();
            return await client.Get(id, headers);
        }

        public static async Task<SubscriptionResponse> Deactivate(string id, HeaderParameter? headers = null)
        {
            SubscriptionClient client = new SubscriptionClient();
            return await client.Deactivate(id, headers);
        }

        public static async Task<SubscriptionCycle[]> GetCycles(string planId, HeaderParameter? headers = null)
        {
            SubscriptionClient client = new SubscriptionClient();
            return (await client.GetCycles(planId, headers)).Data;
        }

        public static async Task<SubscriptionCycle> ForceAttempt(string planId, string cycleId, HeaderParameter? headers = null)
        {
            SubscriptionClient client = new SubscriptionClient();
            return await client.ForceAttempt(planId, cycleId, headers);
        }

        public static async Task<SubscriptionCycle> SimulateCycle(string planId, string cycleId, HeaderParameter? headers = null)
        {
            SubscriptionClient client = new SubscriptionClient();
            return await client.SimulateCycle(planId, cycleId, headers);
        }
    }
}
