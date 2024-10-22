namespace MauiApp1.Services
{
    public interface INavigationService
    {
        Task GoToAsync(string route);
    
        Task GoBackAsync();
    }
}
