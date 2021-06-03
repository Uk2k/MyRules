namespace MyRules.BusinessTests.OrderRules
{
    using System.Threading.Tasks;
    using Business.Memberships;
    using Business.OrderRules;
    using Contracts;
    using Contracts.Products;
    using NSubstitute;
    using NUnit.Framework;

    public class UpgradeMembershipOrderRuleTests
    {
        private IMembershipHandler membershipHandler;
        private UpgradeMembershipOrderRule ruleUnderTest;
        private Product product;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.membershipHandler = Substitute.For<IMembershipHandler>();

            this.ruleUnderTest = new UpgradeMembershipOrderRule(this.membershipHandler);
        }

        [Test]
        public async Task ShouldCreatePackingSlip()
        {
            var membership = new Membership("new member");

            this.order = new Order("", 1, membership);

            await this.ruleUnderTest.CheckRule(order);

            await this.membershipHandler.Received().Upgrade(order);
        }

        [Test]
        public async Task ShouldNotCreatePackingSlip()
        {
            var nonMembership = new EBook("new member");

            this.order = new Order("", 1, nonMembership);

            await this.ruleUnderTest.CheckRule(order);

            await this.membershipHandler.DidNotReceive().Upgrade(order);
        }
    }
}