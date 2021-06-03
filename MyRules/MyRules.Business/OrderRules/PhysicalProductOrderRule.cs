namespace MyRules.Business.OrderRules
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Contracts;
    using PackingSlips;

    public class PhysicalProductOrderRule : IOrderRule
    {
        private readonly IPackingSlipHandler _packingSlipHandler;

        public PhysicalProductOrderRule(IPackingSlipHandler packingSlipHandler)
        {
            _packingSlipHandler = packingSlipHandler;
        }

        public async Task CheckRule(IOrder order)
        {

        }
    }
}
