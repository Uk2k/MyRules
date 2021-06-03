namespace MyRules.Business.Extensions
{
    using System.Linq;
    using Contracts;

    public static class ProductExtensions
    {
        public static bool IsPhysical(this Product product)
        {
            return product.ProductTypes.Contains(Product.ProductType.Physical);
        }

        public static bool ContainsBook(this Product product)
        {
            return product.ProductTypes.Contains(Product.ProductType.Book);
        }

        public static bool ContainsNewMembership(this Product product)
        {
            return product.ProductTypes.Contains(Product.ProductType.NewMembership);
        }

        public static bool ContainsUpgradeMembership(this Product product)
        {
            return product.ProductTypes.Contains(Product.ProductType.UpgradeMembership);
        }
    }
}
