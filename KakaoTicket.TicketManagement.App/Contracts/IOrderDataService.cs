using KakaoTicket.TicketManagement.App.ViewModels;
using System;
using System.Threading.Tasks;

namespace KakaoTicket.TicketManagement.App.Contracts
{
    public interface IOrderDataService
    {
        Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size);
    }
}
