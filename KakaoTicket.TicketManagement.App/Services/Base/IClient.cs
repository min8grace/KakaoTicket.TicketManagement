using System.Net.Http;

namespace KakaoTicket.TicketManagement.App.Services
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }

    }
}
