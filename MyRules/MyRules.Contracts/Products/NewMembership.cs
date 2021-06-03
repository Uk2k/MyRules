namespace MyRules.Contracts.Products
{
    using System.Collections.Generic;

    public class NewMembership : Product
    {
        public NewMembership(string description) : base(description, new List<ProductType>() {ProductType.NewMembership})
        {
        }
    }
}