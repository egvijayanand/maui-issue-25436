namespace MauiApp1.ViewModels
{
    public partial class LoginViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
        [RelayCommand]
        private Task LoginAsync() => NavigationService.GoToAsync("//home");
    }
}
