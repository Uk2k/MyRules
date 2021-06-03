namespace MyRules.BusinessTests.OrderRules
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Business.OrderRules;
    using Contracts;
    using NSubstitute;
    using NUnit.Framework;

    public class PhysicalProductOrderRuleTests
    {
        private PhysicalProductOrderRule ruleUnderTest;
        private Product product;
        private Order order;

        [SetUp]
        public void Setup()
        {

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
