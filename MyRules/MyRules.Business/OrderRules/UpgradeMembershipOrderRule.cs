namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Contracts;
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
            throw new NotImplementedException();
        }
    }
}
