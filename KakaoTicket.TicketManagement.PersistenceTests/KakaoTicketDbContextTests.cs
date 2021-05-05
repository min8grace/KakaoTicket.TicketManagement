using KakaoTicket.TicketManagement.Application.Contracts;
using KakaoTicket.TicketManagement.Domain.Entities;
using KakaoTicket.TicketManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using Xunit;

namespace KakaoTicket.TicketManagement.PersistenceTests
{
    public class KakaoTicketDbContextTests
    {
        private readonly KakaoTicketDbContext _kakaoTicketDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public KakaoTicketDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<KakaoTicketDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _kakaoTicketDbContext = new KakaoTicketDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }

        [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var ev = new Event() {EventId = Guid.NewGuid(), Name = "Test event" };

            _kakaoTicketDbContext.Events.Add(ev);
            await _kakaoTicketDbContext.SaveChangesAsync();

            ev.CreatedBy.ShouldBe(_loggedInUserId);
        }
    }
}
