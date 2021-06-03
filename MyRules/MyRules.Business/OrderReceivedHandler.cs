namespace MyRules.Business
{
    using System.Collections.Generic;
    using OrderRules;

    public class OrderReceivedHandler
    {
        private readonly IEnumerable<IOrderRule> _orderRules;

        public OrderReceivedHandler(IEnumerable<IOrderRule> orderRules)
        {
            _orderRules = orderRules;
        }

    }
}
