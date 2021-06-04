namespace MyRules.Business.OrderRules
{
    using System.Threading.Tasks;
    using Commissions;
    using Contracts;
    using Extensions;

    public class AgentCommissionOrderRule : IOrderRule
    {
        private readonly ICommissionHandler _commissionHandler;

        public AgentCommissionOrderRule(ICommissionHandler commissionHandler)
        {
            _commissionHandler = commissionHandler;
        }

        public async Task CheckRule(IOrder order)
        {
            if (order.Product.ContainsBook() || order.Product.IsPhysical())
            {
                await this._commissionHandler.PayAgent(order);
            }
        }
    }
}
