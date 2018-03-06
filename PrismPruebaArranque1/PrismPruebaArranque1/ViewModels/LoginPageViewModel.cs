using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace PrismPruebaArranque1.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

            Title = "Login";

            LoginCommand = new DelegateCommand(OnLoginCommandExecuted);
        }

        public DelegateCommand LoginCommand { get; }

        private async void OnLoginCommandExecuted()
        {
            await _navigationService.NavigateAsync("/MainPage/NavigationPage/ViewA");
        }
        
    }
}
