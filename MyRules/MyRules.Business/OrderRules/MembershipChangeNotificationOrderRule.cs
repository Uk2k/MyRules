namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Contracts;
    using Emailer;
    using Extensions;

    public class MembershipChangeNotificationOrderRule : IOrderRule
    {
        private readonly IEmailerClient _emailerClient;

        public MembershipChangeNotificationOrderRule(IEmailerClient emailerClient)
        {
            _emailerClient = emailerClient;
        }

        public async Task CheckRule(IOrder order)
        {
            if (order.Product.ContainsNewMembership())
            {
                await this._emailerClient.SendEmail(order, "Account Activated");
            }

            if (order.Product.ContainsUpgradeMembership())
            {
                await this._emailerClient.SendEmail(order, "Account Upgraded");
            }
        }
    }
}
