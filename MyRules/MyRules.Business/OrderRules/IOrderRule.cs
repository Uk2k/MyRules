namespace MyRules.Business.OrderRules
{
    using System.Threading.Tasks;
    using Contracts;

    public interface IOrderRule
    {
        Task CheckRule(Order order);
    }
}
