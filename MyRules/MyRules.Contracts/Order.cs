namespace MyRules.Contracts
{
    public class Order : IOrder
    {
        public string Customer { get; }

        public decimal Payment { get; }

        public Product Product { get; }

        public Order(string customer, decimal payment, Product product)
        {
            Customer = customer;
            Payment = payment;
            Product = product;
        }
    }
}
