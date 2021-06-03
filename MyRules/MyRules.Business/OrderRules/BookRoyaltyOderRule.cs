namespace MyRules.Business.OrderRules
{
    using System.Linq;
    using System.Threading.Tasks;
    using Contracts;
    using Extensions;
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
            if (order.Product.ContainsBook())
            {
                await _packingSlipHandler.CreatePackingSlipWithReason(order.Product, "For royalty payments");
            }
        }
    }
}
