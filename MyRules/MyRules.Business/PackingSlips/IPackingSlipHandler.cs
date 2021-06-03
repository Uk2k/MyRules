namespace MyRules.Business.PackingSlips
{
    using System.Threading.Tasks;
    using Contracts;

    public interface IPackingSlipHandler
    {
        Task CreatePackingSlip(Product product);
    }
}
