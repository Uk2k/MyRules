namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Contracts;
    using PackingSlips;

    public class BookRoyaltyOderRule : IOrderRule
    {
        private readonly IPackingSlipHandler _packingSlipHandler;

        public BookRoyaltyOderRule(IPackingSlipHandler packingSlipHandler)
        {
            _packingSlipHandler = packingSlipHandler;
        }

        public async Task CheckRule(IOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
