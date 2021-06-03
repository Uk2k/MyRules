namespace MyRules.Contracts.Products
{
    using System.Collections.Generic;

    public class UpgradeMembership : Product
    {
        public UpgradeMembership(string description) : base(description, new List<ProductType>() {ProductType.UpgradeMembership})
        {
        }
    }
}