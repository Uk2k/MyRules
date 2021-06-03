namespace MyRules.Contracts.Products
{
    using System.Collections.Generic;

    public class Membership : Product
    {
        public Membership(string description) : base(description, new List<ProductType>() {ProductType.Membership})
        {
        }
    }
}