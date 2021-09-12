using Learn.ShinyBackground.ViewModels;
using Learn.ShinyBackground.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Learn.ShinyBackground
{
  public partial class App
  {
    public App(IPlatformInitializer initializer)
      : base(initializer)
    {
    }

    protected override async void OnInitialized()
    {
      InitializeComponent();

      await NavigationService.NavigateAsync("NavigationPage/MainPage");
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

      containerRegistry.RegisterForNavigation<NavigationPage>();
      containerRegistry.RegisterForNavigation<MainView, MainPageViewModel>();
      containerRegistry.RegisterForNavigation<LogView, LogViewModel>();
      containerRegistry.RegisterForNavigation<JobsView, JobsViewModel>();
      containerRegistry.RegisterForNavigation<CreateView, CreateViewViewModel>();
    }
  }
}
