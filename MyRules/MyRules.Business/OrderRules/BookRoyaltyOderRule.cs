namespace MyRules.Business.OrderRules
{
    using System.Linq;
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
            if (order.Product.ProductTypes.Contains(Product.ProductType.Book))
            {
                await _packingSlipHandler.CreatePackingSlipWithReason(order.Product, "For royalty payments");
            }
        }
    }
}
