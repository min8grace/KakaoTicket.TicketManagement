using KakaoTicket.TicketManagement.App.Services;
using KakaoTicket.TicketManagement.App.Services.Base;
using KakaoTicket.TicketManagement.App.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KakaoTicket.TicketManagement.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryEventsViewModel>> GetAllCategoriesWithEvents(bool includeHistory);
        Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}
