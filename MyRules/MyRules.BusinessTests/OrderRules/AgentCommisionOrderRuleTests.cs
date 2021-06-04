namespace MyRules.BusinessTests.OrderRules
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Business.Commissions;
    using Business.OrderRules;
    using Contracts;
    using Contracts.Products;
    using NSubstitute;
    using NUnit.Framework;

    public class AgentCommisionOrderRuleTests
    {
        private ICommissionHandler _commissionHandler;
        private AgentCommissionOrderRule _ruleUnderTest;
        private Order _order;

        [SetUp]
        public void Setup()
        {
            this._commissionHandler = Substitute.For<ICommissionHandler>();

            this._ruleUnderTest = new AgentCommissionOrderRule(this._commissionHandler);
        }

        [Test]
        public async Task ShouldSendCommission()
        {
            var book = new PhysicalBook("Title");

            this._order = new Order("", 1, book);

            await this._ruleUnderTest.CheckRule(this._order);

            await this._commissionHandler.Received().PayAgent(this._order);
        }

        [Test]
        public async Task EbookShouldSendCommission()
        {
            var book = new EBook("Title");

            this._order = new Order("", 1, book);

            await this._ruleUnderTest.CheckRule(this._order);

            await this._commissionHandler.Received().PayAgent(this._order);
        }

        [Test]
        public async Task ShouldNotSendCommission()
        {
            var product = new Product("", new List<Product.ProductType>());

            this._order = new Order("", 1, product);

            await this._ruleUnderTest.CheckRule(this._order);

            await this._commissionHandler.DidNotReceive().PayAgent(_order);
        }
    }
}