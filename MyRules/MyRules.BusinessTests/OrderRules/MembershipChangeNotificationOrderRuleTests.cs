namespace MyRules.BusinessTests.OrderRules
{
    using System.Threading.Tasks;
    using Business.Emailer;
    using Business.Memberships;
    using Business.OrderRules;
    using Contracts;
    using Contracts.Products;
    using NSubstitute;
    using NUnit.Framework;

    public class MembershipChangeNotificationOrderRuleTests
    {
        private IEmailerClient emailerClient;
        private MembershipChangeNotificationOrderRule ruleUnderTest;
        private Product product;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.emailerClient = Substitute.For<IEmailerClient>();
            this.ruleUnderTest = new MembershipChangeNotificationOrderRule(this.emailerClient);
        }

        [Test]
        public async Task ShouldCallEmailerWithNewMembership()
        {
            this.product = new NewMembership("Upgrade member");

            this.order = new Order("Customer", 1, this.product);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.emailerClient.Received().SendEmail(this.order, "Account Activated");
        }

        [Test]
        public async Task ShouldCallEmailerWithUpgradeMembership()
        {
            this.product = new UpgradeMembership("Upgrade member");

            this.order = new Order("Customer", 1, this.product);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.emailerClient.Received().SendEmail(this.order, "Account Upgraded");
        }

        [Test]
        public async Task ShouldNotCallEmailerWhenNotMembershipRelated()
        {
            this.product = new EBook("Book");

            this.order = new Order("Customer", 1, this.product);

            await this.ruleUnderTest.CheckRule(this.order);

            await this.emailerClient.DidNotReceive().SendEmail(this.order, Arg.Any<string>());
        }
    }
}