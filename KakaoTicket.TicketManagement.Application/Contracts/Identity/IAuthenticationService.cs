using KakaoTicket.TicketManagement.Application.Models.Authentication;
using System.Threading.Tasks;

namespace KakaoTicket.TicketManagement.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
