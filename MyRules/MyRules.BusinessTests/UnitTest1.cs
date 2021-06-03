namespace MyRules.BusinessTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Business;
    using Business.OrderRules;
    using Contracts;
    using NSubstitute;
    using NUnit.Framework;

    public class OrderReceivedHandlerTests
    {
        private OrderReceivedHandler handlerUnderTest;
        private List<IOrderRule> _orderRuleList;

        [SetUp]
        public void Setup()
        {
            this._orderRuleList = new List<IOrderRule>();
        }

        [Test]
        public async Task RunsAllSuppliedRules()
        {
            var mockRule1 = Substitute.For<IOrderRule>();
            var mockRule2 = Substitute.For<IOrderRule>();
            var order = Substitute.For<IOrder>();
            this._orderRuleList.Add(mockRule1);
            this._orderRuleList.Add(mockRule2);
            this.handlerUnderTest = new OrderReceivedHandler(this._orderRuleList);

            await this.handlerUnderTest.RunRulesEngine(order);

            await mockRule1.Received().CheckRule(order);
            await mockRule2.Received().CheckRule(order);
        }
    }
}