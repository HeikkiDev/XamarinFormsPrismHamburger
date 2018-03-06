using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismPruebaArranque1.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Home Page";

            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        public DelegateCommand<string> NavigateCommand { get; }

        private async void OnNavigateCommandExecuted(string path)
        {
            await _navigationService.NavigateAsync(path);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() == NavigationMode.New)
            {
                IsBusy = true;
                IsBusy = false;
            }
        }
    }
}
