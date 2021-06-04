namespace MyRules.Business.Commisions
{
    using System.Threading.Tasks;
    using Contracts;
    using OrderRules;

    public interface ICommisionHandler
    {
        Task PayAgent(IOrder order);
    }
}
