using System;
using System.Threading;
using System.Threading.Tasks;
using Learn.ShinyBackground.Services;
using Shiny;
using Shiny.Jobs;

namespace Learn.ShinyBackground.Jobs
{
  public class SampleJob : IJob, IShinyStartupTask
  {
    private readonly LogService _log;
    private readonly CoreDelegateServices _services;

    public SampleJob(LogService log, CoreDelegateServices services)
    {
      _log = log;
      _services = services;
    }

    public async Task Run(JobInfo jobInfo, CancellationToken cancelToken)
    {
      ////await _notifications.Send(this.GetType(), true, "Job Started", $"{jobInfo.Identifier} Started");

      _log.Debug("Job Started - " + jobInfo.Identifier);
      var seconds = jobInfo.GetParameter("SecondsToRun", 10);

      await Task.Delay(TimeSpan.FromSeconds(seconds), cancelToken);

      ////await _notifications.Send(this.GetType(), false, "Job Finished", $"{jobInfo.Identifier} Finished");
    }

    public void Start()
    {
      // _notifications.Register(this.GetType(), true, "Jobs");
      throw new NotImplementedException();
    }
  }
}
