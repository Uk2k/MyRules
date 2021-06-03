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
        private Product product;
        private Order order;

        [SetUp]
        public void Setup()
        {
            this.membershipHandler = Substitute.For<IMembershipHandler>();
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