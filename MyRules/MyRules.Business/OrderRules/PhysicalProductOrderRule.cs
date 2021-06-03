namespace MyRules.Business.OrderRules
{
    using System;
    using System.Threading.Tasks;
    using Contracts;

    public class PhysicalProductOrderRule : IOrderRule
    {
        public PhysicalProductOrderRule()
        {
            
        }

        public Task CheckRule(IOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
