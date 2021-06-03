namespace MyRules.BusinessTests.OrderRules
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Business.OrderRules;
    using Business.PackingSlips;
    using Contracts;
    using Contracts.Products;
    using NSubstitute;
    using NUnit.Framework;

    public class BookRoyaltyOrderRuleTests
    {
        private IPackingSlipHandler packingSlipHandler;
        private BookRoyaltyOderRule ruleUnderTest;
        private Product product;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.packingSlipHandler = Substitute.For<IPackingSlipHandler>();

            this.ruleUnderTest = new BookRoyaltyOderRule(this.packingSlipHandler);
        }

        [Test]
        public async Task ShouldCreatePackingSlip()
        {
            var book = new PhysicalBook("Title");

            this.order = new Order("", 1, book);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.packingSlipHandler.Received().CreatePackingSlipWithReason(book, "For royalty payments");
        }

        [Test]
        public async Task ShouldNotCreatePackingSlip()
        {
            var product = new Product("", new List<Product.ProductType>());

            this.order = new Order("", 1, product);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.packingSlipHandler.DidNotReceive().CreatePackingSlipWithReason(product, "For royalty payments");
        }
    }
}