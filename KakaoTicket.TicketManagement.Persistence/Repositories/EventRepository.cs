using KakaoTicket.TicketManagement.Application.Contracts.Persistence;
using KakaoTicket.TicketManagement.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KakaoTicket.TicketManagement.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(KakaoTicketDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches =  _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }
    }
}
