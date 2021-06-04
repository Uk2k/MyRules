namespace MyRules.Business.Commissions
{
    using System.Threading.Tasks;
    using Contracts;

    public interface ICommissionHandler
    {
        Task PayAgent(IOrder order);
    }
}
