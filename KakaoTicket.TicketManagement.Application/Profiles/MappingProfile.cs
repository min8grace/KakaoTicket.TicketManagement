using AutoMapper;
using KakaoTicket.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;
using KakaoTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using KakaoTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using KakaoTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using KakaoTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using KakaoTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using KakaoTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using KakaoTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using KakaoTicket.TicketManagement.Application.Features.Orders.GetOrdersForMonth;
using KakaoTicket.TicketManagement.Domain.Entities;

namespace KakaoTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
