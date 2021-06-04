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

    public class LearningToSkiOrderRuleTests
    {
        private IPackingSlipHandler packingSlipHandler;
        private LearningToSkiOrderRule ruleUnderTest;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.packingSlipHandler = Substitute.For<IPackingSlipHandler>();

            this.ruleUnderTest = new LearningToSkiOrderRule(this.packingSlipHandler);
        }

        [Test]
        public async Task ShouldCreatePackingSlip()
        {
            var book = new PhysicalBook("Learning To Ski");

            this.order = new Order("", 1, book);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.packingSlipHandler.Received().CreatePackingSlipWithReason(book, "the result of a court decision in 1997");
        }

        [Test]
        public async Task ShouldNotCreatePackingSlip()
        {
            var book = new PhysicalBook("Learning to sow");

            this.order = new Order("", 1, book);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.packingSlipHandler.DidNotReceive().CreatePackingSlipWithReason(book, "the result of a court decision in 1997");
        }

    }
}