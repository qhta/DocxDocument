using ModelGenApp.Views;

namespace ModelGenApp.ViewModels;

public partial class ProcessMonitor : ModelMonitor
{

  public ProcessMonitorViewModel ProcessMonitorVM { get; set; } = new();
  
  public int IndentLevel { get; set; }

  public int IndentSize { get; set; } = 2;


  public override void WriteLine()
  {
    DispatcherHelper.Execute(() => ProcessMonitorVM.Lines.Add(string.Empty));
  }

  public override void WriteLine(string line)
  {
    DispatcherHelper.Execute(() => ProcessMonitorVM.Lines.Add(line));
  }

  public override void WriteSameLine(string line)
  {
    DispatcherHelper.Execute(() => ProcessMonitorVM.StatusLine = line);
  }

  public override void Indent()
  {
    IndentLevel++;
  }

  public override void Unindent()
  {
    if (IndentLevel > 0)
      IndentLevel--;
  }

  public override void ShowProcessStart(string line)
  {
    base.ShowProcessStart(line);
    //PhaseMonitors = new();
  }

  public override void ShowPhaseStart(PPS phaseNumber, string phaseName)
  {
    base.ShowPhaseStart(phaseNumber, phaseName);
    //if (PhaseMonitors != null)
    {
      DispatcherHelper.Execute(() =>
      { 
        //PhaseMonitor phaseMonitor;
        //PhaseMonitors.Add(phaseMonitor = new PhaseMonitor { PhaseNumber = PhaseNum, PhaseName = phaseName });
        //PhaseMonitors0 = phaseMonitor;
        ProcessMonitorVM.Percentage = 10;
        //(Application.Current.MainWindow as MainWindow).ProcessOptionsView.ProgressBar.Value = 0;
      });
    }
  }

  public override void ShowPhaseProgress(PPS phaseNumber, ProgressInfo info)
  {
    base.ShowPhaseProgress(phaseNumber, info);
    //if (PhaseMonitors != null)
    {
      //var phaseMonitor = PhaseMonitors.FirstOrDefault(item => item.PhaseNumber == phaseNumber);
      //if (phaseMonitor != null)
      {
        //if (phaseMonitor.Progress == null)
        //  phaseMonitor.Progress = new Progress<int>();
        var percentage = (info.Done??0)*100/(info.Total??100);
        //(Application.Current.MainWindow as MainWindow).ProcessOptionsView.ProgressBar.Value = percentage;
        //Debug.WriteLine($"ShowPhaseProgress.Update.Begin({percentage})");
        ProcessMonitorVM.Percentage=percentage;
        //Debug.WriteLine($"ShowPhaseProgress.Update.End({percentage})");
      }
    }
  }

  public override void ShowPhaseEnd(PPS phaseNumber, SummaryInfo info)
  {
    base.ShowPhaseEnd(phaseNumber, info);
    //if (PhaseMonitors != null)
    {
      //var phaseMonitor = PhaseMonitors.FirstOrDefault(item => item.PhaseNumber == phaseNumber);
      //if (phaseMonitor != null)
      //  phaseMonitor.SummaryInfo = info;
    }
  }

  public override DocumentationWriter GetDocumentationWriter(DisplayOptions options)
  {
    throw new NotImplementedException();
  }
}
