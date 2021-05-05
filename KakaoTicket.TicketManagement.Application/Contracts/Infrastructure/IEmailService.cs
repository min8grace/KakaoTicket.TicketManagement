using KakaoTicket.TicketManagement.Application.Models.Mail;
using System.Threading.Tasks;

namespace KakaoTicket.TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
