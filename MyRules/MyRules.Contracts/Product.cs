namespace MyRules.Contracts
{
    using System.Collections.Generic;

    public class Product
    {
        public enum ProductType
        {
            Physical,
            Membership,
            Upgrade,
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
