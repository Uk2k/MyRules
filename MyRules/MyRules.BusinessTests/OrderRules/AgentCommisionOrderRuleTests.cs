namespace MyRules.BusinessTests.OrderRules
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Business.Commisions;
    using Business.OrderRules;
    using Business.PackingSlips;
    using Contracts;
    using Contracts.Products;
    using NSubstitute;
    using NUnit.Framework;

    public class AgentCommisionOrderRuleTests
    {
        private ICommisionHandler commisionHandler;
        private AgentCommisionOrderRule ruleUnderTest;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.commisionHandler = Substitute.For<ICommisionHandler>();

            this.ruleUnderTest = new AgentCommisionOrderRule(this.commisionHandler);
        }

        [Test]
        public async Task ShouldSendCommision()
        {
            var book = new PhysicalBook("Title");

            this.order = new Order("", 1, book);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.commisionHandler.Received().PayAgent(this.order);
        }

        [Test]
        public async Task EbookShouldSendCommision()
        {
            var book = new EBook("Title");

            this.order = new Order("", 1, book);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.commisionHandler.Received().PayAgent(this.order);
        }

        [Test]
        public async Task ShouldNotSendCommision()
        {
            var product = new Product("", new List<Product.ProductType>());

            this.order = new Order("", 1, product);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.commisionHandler.DidNotReceive().PayAgent(order);
        }
    }
}