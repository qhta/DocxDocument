using ModelGenApp.Views;

namespace ModelGenApp.ViewModels;

public partial class ProcessMonitor : ModelMonitor
{

  public ProcessMonitorViewModel VM { get; set; } = new();

  public int IndentLevel { get; set; }

  public int IndentSize { get; set; } = 2;


  public override void WriteLine()
  {
    DispatcherHelper.Execute(() => VM.Lines.Add(string.Empty));
  }

  public override void WriteLine(string line)
  {
    DispatcherHelper.Execute(() => VM.Lines.Add(line));
  }

  public override void WriteSameLine(string line)
  {
    DispatcherHelper.Execute(() => VM.StatusLine = line);
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
    const int numPhases = 6;
    VM.PhaseMonitors = new PhaseMonitor[numPhases];
    for (int i = 0; i < numPhases; i++)
      VM.PhaseMonitors[i] = new PhaseMonitor();
  }

  public override void ShowPhaseStart(PPS phaseNumber, string phaseName)
  {
    base.ShowPhaseStart(phaseNumber, phaseName);
    VM.PhaseMonitors[(int)phaseNumber-1].Percentage = 0;
  }

  public override void ShowPhaseProgress(PPS phaseNumber, ProgressInfo info)
  {
    base.ShowPhaseProgress(phaseNumber, info);
    var percentage = (info.Done ?? 0) * 100 / (info.Total ?? 100);
    VM.PhaseMonitors[(int)phaseNumber-1].Percentage = percentage;
  }

  public override void ShowPhaseEnd(PPS phaseNumber, SummaryInfo info)
  {
    base.ShowPhaseEnd(phaseNumber, info);
    VM.PhaseMonitors[(int)phaseNumber-1].Percentage = 100;
  }

  public override DocumentationWriter GetDocumentationWriter(DisplayOptions options)
  {
    throw new NotImplementedException();
  }
}
