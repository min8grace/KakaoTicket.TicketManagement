using Microsoft.AspNetCore.Components;

namespace KakaoTicket.TicketManagement.App.Pages
{
    public partial class Index
    {
       
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected void NavigateToLogin()
        {
            NavigationManager.NavigateTo("login");
        }

        protected void NavigateToRegister()
        {
            NavigationManager.NavigateTo("register");
        }

   }
}
