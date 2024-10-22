namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new MainWindow();
        }
    }
}
