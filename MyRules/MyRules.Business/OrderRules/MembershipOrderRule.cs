namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Contracts;
    using Memberships;

    public class MembershipOrderRule : IOrderRule
    {
        private readonly IMembershipHandler _membershipHandler;

        public MembershipOrderRule(IMembershipHandler membershipHandler)
        {
            _membershipHandler = membershipHandler;
        }

        public async Task CheckRule(IOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
