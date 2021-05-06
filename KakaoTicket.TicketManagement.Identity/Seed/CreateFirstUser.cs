using KakaoTicket.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace KakaoTicket.TicketManagement.Identity.Seed
{
    public static class UserCreator
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "Johson",
                LastName = "Park",
                UserName = "JohsonPark",
                Email = "Johson@test.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "Johson&01?");
            }
        }
    }
}