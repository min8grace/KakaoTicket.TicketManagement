using AutoMapper;
using KakaoTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using KakaoTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using KakaoTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using KakaoTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using KakaoTicket.TicketManagement.Domain.Entities;

namespace KakaoTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
        }
    }
}
