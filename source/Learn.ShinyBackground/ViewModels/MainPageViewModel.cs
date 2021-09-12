using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using Learn.ShinyBackground.Controls;
using Learn.ShinyBackground.Views;
using Prism.Commands;
using Prism.Navigation;
using Shiny.Jobs;

namespace Learn.ShinyBackground.ViewModels
{
  public class MainPageViewModel : ViewModelBase
  {
    private IJobManager _jobManager;
    private List<CommandItem> _jobs;

    public MainPageViewModel(INavigationService navigationService, IJobManager jobManager)
      : base(navigationService)
    {
      Title = "Main Page";
      _jobManager = jobManager;
    }

    public DelegateCommand CmdCreate => new DelegateCommand(() => NavigationService.Navigate(nameof(CreateView)));

    public DelegateCommand CmdLoadJobs => new DelegateCommand(OnLoadJobsAsync);

    private async void OnLoadJobsAsync()
    {
      var jobs = await _jobManager.GetJobs();
      Jobs = jobs
      .Select(x => new CommandItem {
        Text = x.Identifier,
        Detail = x.LastRunUtc?.ToLocalTime().ToString("G") ?? "Never Run",
        PrimaryCommand = new DelegateCommand(() => _jobManager.Run(x.Identifier)),
        SecondaryCommand = new DelegateCommand(async () =>
        {
          await _jobManager.Cancel(x.Identifier);
          CmdLoadJobs?.Execute();
        })

        ////PrimaryCommand = ReactiveCommand.CreateFromTask(() => jobManager.Run(x.Identifier)),
        ////SecondaryCommand = ReactiveCommand.CreateFromTask(async () =>
        ////{
        ////  await jobManager.Cancel(x.Identifier);
        ////  this.LoadJobs.Execute(null);
        ////})
      })
      .ToList();
    }

    private void OnDoSomehing()
    {
      throw new NotImplementedException();
    }

    // [Reactive] public List<CommandItem> ...
    public List<CommandItem> Jobs
    {
      get => _jobs;
      private set => SetProperty(ref _jobs, value);
    }
  }
}
