namespace MyRules.Contracts
{
    public interface IOrder
    {
        public string Customer { get; }

        public decimal Payment { get; }

        public Product Product { get; }
    }
}