namespace MyRules.Business.Emailer
{
    using System.Threading.Tasks;
    using Contracts;

    public interface IEmailerClient
    {
        Task SendEmail(IOrder order, string subject);
    }
}
