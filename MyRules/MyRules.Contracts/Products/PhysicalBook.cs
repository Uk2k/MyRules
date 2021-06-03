namespace MyRules.Contracts.Products
{
    using System.Collections.Generic;

    public class PhysicalBook : Product
    {
        public PhysicalBook(string description) : base(description, new List<ProductType>() {ProductType.Physical, ProductType.Book})
        {
        }
    }
}
