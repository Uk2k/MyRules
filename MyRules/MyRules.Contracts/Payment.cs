namespace MyRules.Contracts
{
    public class Payment
    {
        public decimal Value { get; }

        public Payment(decimal value)
        {
            Value = value;
        }
    }
}