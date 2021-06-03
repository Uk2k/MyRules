namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Contracts;
    using Extensions;
    using PackingSlips;

    public class LearningToSkiOrderRule : IOrderRule
    {
        private readonly IPackingSlipHandler _packingSlipHandler;

        public LearningToSkiOrderRule(IPackingSlipHandler packingSlipHandler)
        {
            _packingSlipHandler = packingSlipHandler;
        }

        public async Task CheckRule(IOrder order)
        {
            if (!order.Product.ContainsBook())
            {
                return;
            }

            if (order.Product.Description.Equals("Learning To Ski"))
            {
                await this._packingSlipHandler.CreatePackingSlipWithReason(order.Product,
                    "the result of a court decision in 1997");
            }
        }
    }
}
