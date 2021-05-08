using KakaoTicket.TicketManagement.App.Contracts;
using KakaoTicket.TicketManagement.App.ViewModels;
using Microsoft.AspNetCore.Components;

namespace KakaoTicket.TicketManagement.App.Pages
{
    public partial class Register
    {

        public RegisterViewModel RegisterViewModel { get; set; } //= new RegisterViewModel();

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string Message { get; set; }

        [Inject]
        private IAuthenticationService AuthenticationService { get; set; }

        public Register()
        {

        }
        protected override void OnInitialized()
        {
            RegisterViewModel = new RegisterViewModel();
        }

        protected async void HandleValidSubmit()
        {
            var result = await AuthenticationService.Register(RegisterViewModel.FirstName, RegisterViewModel.LastName, RegisterViewModel.UserName, RegisterViewModel.Email, RegisterViewModel.Password);

            if (result)
            {
                if (await AuthenticationService.Authenticate(RegisterViewModel.Email, RegisterViewModel.Password))
                {
                    NavigationManager.NavigateTo("home");
                }

                Message = "Something went wrong, please try again.";
            }
            Message = "Something went wrong, please try again.";
        }
    }
}
