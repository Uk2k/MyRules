namespace MyRules.BusinessTests.OrderRules
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Business.OrderRules;
    using Business.PackingSlips;
    using Contracts;
    using NSubstitute;
    using NUnit.Framework;

    public class PhysicalProductOrderRuleTests
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
            this.product =
                new Product("Physical", new List<Product.ProductType>() {Product.ProductType.Physical });

            this.order = new Order("", 1, this.product);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.packingSlipHandler.Received().CreatePackingSlip(this.product);
        }

        [Test]
        public async Task ShouldNotCreatePackingSlip()
        {
            this.product =
                new Product("NonPhysical", new List<Product.ProductType>());

            this.order = new Order("", 1, this.product);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.packingSlipHandler.DidNotReceive().CreatePackingSlip(this.product);
        }
    }
}
