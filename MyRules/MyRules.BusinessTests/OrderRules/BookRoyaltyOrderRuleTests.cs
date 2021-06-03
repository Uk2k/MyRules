namespace MyRules.BusinessTests.OrderRules
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Business.OrderRules;
    using Business.PackingSlips;
    using Contracts;
    using NSubstitute;
    using NUnit.Framework;

    public class BookRoyaltyOrderRuleTests
    {
        private IPackingSlipHandler packingSlipHandler;
        private PhysicalProductOrderRule ruleUnderTest;
        private Product product;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.packingSlipHandler = Substitute.For<IPackingSlipHandler>();

            this.ruleUnderTest = new PhysicalProductOrderRule(this.packingSlipHandler);
        }

        [Test]
        public async Task ShouldCreatePackingSlip()
        {

        }

        [Test]
        public async Task ShouldNotCreatePackingSlip()
        {

        }
    }
}