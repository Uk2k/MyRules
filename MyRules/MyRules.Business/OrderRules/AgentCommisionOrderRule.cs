namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Commisions;
    using Contracts;

    public class AgentCommisionOrderRule : IOrderRule
    {
        private readonly ICommisionHandler _commisionHandler;

        public AgentCommisionOrderRule(ICommisionHandler commisionHandler)
        {
            _commisionHandler = commisionHandler;
        }

        public async Task CheckRule(IOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
