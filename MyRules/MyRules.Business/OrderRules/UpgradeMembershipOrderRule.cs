namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Contracts;
    using Extensions;
    using Memberships;

    public class UpgradeMembershipOrderRule : IOrderRule
    {
        private readonly IMembershipHandler _membershipHandler;

        public UpgradeMembershipOrderRule(IMembershipHandler membershipHandler)
        {
            _membershipHandler = membershipHandler;
        }

        public async Task CheckRule(IOrder order)
        {
            if(order.Product.ContainsUpgradeMembership())
            {
                await this._membershipHandler.Upgrade(order);
            }
        }
    }
}
