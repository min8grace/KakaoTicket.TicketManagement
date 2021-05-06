using KakaoTicket.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KakaoTicket.TicketManagement.Identity
{
    public class KakaoTicketIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public KakaoTicketIdentityDbContext(DbContextOptions<KakaoTicketIdentityDbContext> options) : base(options)
        {
        }
    }
}
