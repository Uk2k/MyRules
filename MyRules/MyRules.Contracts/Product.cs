namespace MyRules.Contracts
{
    using System.Collections.Generic;

    public class Product
    {
        public enum ProductType
        {
            Physical,
            Book,
            NewMembership,
            UpgradeMembership,
        }

        public string Description { get; }
        public IReadOnlyList<ProductType> ProductTypes { get; }

        public Product(string description, List<ProductType> productTypes)
        {
            Description = description;
            ProductTypes = productTypes;
        }
    }
}
