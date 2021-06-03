namespace MyRules.BusinessTests.OrderRules
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Business.Memberships;
    using Business.OrderRules;
    using Business.PackingSlips;
    using Contracts;
    using Contracts.Products;
    using NSubstitute;
    using NUnit.Framework;

    public class MembershipOrderRuleTests
    {
        private IMembershipHandler membershipHandler;
        private MembershipOrderRule ruleUnderTest;
        private Product product;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.membershipHandler = Substitute.For<IMembershipHandler>();

            this.ruleUnderTest = new MembershipOrderRule(this.membershipHandler);
        }

        [Test]
        public async Task ShouldCreatePackingSlip()
        {
            var membership = new Membership("new member");

            this.order = new Order("", 1, membership);

            await this.ruleUnderTest.CheckRule(order);

            await this.membershipHandler.Received().Activate(order);
        }

        [Test]
        public async Task ShouldNotCreatePackingSlip()
        {
            var nonMembership = new EBook("new member");

            this.order = new Order("", 1, nonMembership);

            await this.ruleUnderTest.CheckRule(order);

            await this.membershipHandler.DidNotReceive().Activate(order);
        }
    }
}