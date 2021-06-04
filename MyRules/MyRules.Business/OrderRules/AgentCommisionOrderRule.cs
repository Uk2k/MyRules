namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Commisions;
    using Contracts;
    using Extensions;

    public class AgentCommisionOrderRule : IOrderRule
    {
        private readonly ICommisionHandler _commisionHandler;

        public AgentCommisionOrderRule(ICommisionHandler commisionHandler)
        {
            _commisionHandler = commisionHandler;
        }

        public async Task CheckRule(IOrder order)
        {
            if (order.Product.ContainsBook() || order.Product.IsPhysical())
            {
                await this._commisionHandler.PayAgent(order);
            }
        }
    }
}
