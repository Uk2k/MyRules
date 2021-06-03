namespace MyRules.Contracts.Products
{
    using System.Collections.Generic;

    public class EBook : Product
    {
        public EBook(string description) : base(description, new List<ProductType>() {ProductType.Book})
        {
        }
    }
}