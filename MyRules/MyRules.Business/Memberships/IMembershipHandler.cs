namespace MyRules.Business.Memberships
{
    using System.Threading.Tasks;
    using Contracts;

    public interface IMembershipHandler
    {
        Task Activate(IOrder order);

        Task Upgrade(IOrder order);
    }
}
