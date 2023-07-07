using ModelGenApp.Views;

namespace ModelGenApp.ViewModels;

public partial class ProcessMonitor : ModelMonitor
{

  public ProcessMonitorViewModel VM { get; set; } = new();

  public int IndentLevel { get; set; }

  public int IndentSize { get; set; } = 2;


  public override void WriteLine()
  {
    VM.WriteLine();
  }

  public override void WriteLine(string line)
  {
    VM.WriteLine(line);
  }

  public override void WriteSameLine(string line)
  {
    VM.WriteSameLine(line);
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
  }

  public override void ShowPhaseStart(PPS phaseNumber, string phaseName)
  {
    base.ShowPhaseStart(phaseNumber, phaseName);
    var numPhases = VM.PhaseMonitors.Length;
    if (VM.PhaseMonitors[(int)phaseNumber - 1] != null)
      VM.PhaseMonitors[(int)phaseNumber - 1].Percentage = 0;
  }

  public override void ShowPhaseProgress(PPS phaseNumber, ProgressInfo info)
  {
    base.ShowPhaseProgress(phaseNumber, info);
    var percentage = (info.Done ?? 0) * 100 / (info.Total ?? 100);
    if (VM.PhaseMonitors[(int)phaseNumber - 1] != null)
      VM.PhaseMonitors[(int)phaseNumber - 1].Percentage = percentage;
  }

  public override void ShowPhaseEnd(PPS phaseNumber, SummaryInfo info)
  {
    base.ShowPhaseEnd(phaseNumber, info);
    if (VM.PhaseMonitors[(int)phaseNumber - 1] != null)
    {
      VM.PhaseMonitors[(int)phaseNumber - 1].Percentage = 100;
      VM.PhaseMonitors[(int)phaseNumber - 1].SetSummary(info);
    }
  }

  public override DocumentationWriter GetDocumentationWriter(DisplayOptions options)
  {
    throw new NotImplementedException();
  }
}
