namespace ModelGenApp.Helpers;

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

  public override void ShowPhaseStart(PPS phase, string phaseName)
  {
    base.ShowPhaseStart(phase, phaseName);
    var numPhases = VM.PhaseMonitors.Length;
    if (VM.PhaseMonitors[(int)phase - 1] != null)
      VM.PhaseMonitors[(int)phase - 1].Percentage = 0;
  }

  public override void ShowPhaseProgress(PPS phase, ProgressInfo info)
  {
    base.ShowPhaseProgress(phase, info);
    var done = info.CheckedTypes ?? info.ProcessedTypes ?? 0;
    var total = info.TotalTypes ?? 100;
    var percentage = done * 100 / total;
    if (VM.PhaseMonitors[(int)phase - 1] != null)
      VM.PhaseMonitors[(int)phase - 1].Percentage = percentage;
  }

  public override void ShowPhaseEnd(PPS phase, SummaryInfo info)
  {
    base.ShowPhaseEnd(phase, info);
    if (VM.PhaseMonitors[(int)phase - 1] != null)
    {
      VM.PhaseMonitors[(int)phase - 1].Percentage = 100;
      VM.PhaseMonitors[(int)phase - 1].SetSummary(info);
    }
  }

  public override DocumentationWriter GetDocumentationWriter(DisplayOptions options)
  {
    throw new NotImplementedException();
  }
}
