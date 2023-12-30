namespace ModelGenApp.ViewModels;

public class CodeGenPhaseViewModel : PhaseResultsViewModel
{
  public CodeGenPhaseViewModel(string name) : base(PPS.CodeGen, name, NTS.Target)
  {
    CanShowErrorDetails = true;
  }

  public override void SetSummary(SummaryInfo summary)
  {
    if (summary.Summary != null)
    {
      if (summary.Summary.TryGetValue(SummaryInfoKind.GeneratedFileList, out var compilationFileList))
      {
        summary.Summary.Remove(SummaryInfoKind.GeneratedFileList);
        _CompilationFiles = (FilesList)compilationFileList;
      }
      if (summary.Summary.TryGetValue(SummaryInfoKind.CompilationErrorList, out var compilationErrorList))
      {
        summary.Summary.Remove(SummaryInfoKind.CompilationErrorList);
        _CompilationErrors = (CompilationErrors)compilationErrorList;
      }
    }
    base.SetSummary(summary);
  }

  public FileListViewModel? CompilationFiles { [DebuggerStepThrough] get; set; }
  public ErrorListViewModel? CompilationErrors { [DebuggerStepThrough] get; set; }

  private FilesList? _CompilationFiles { [DebuggerStepThrough] get; set; }
  private CompilationErrors? _CompilationErrors { [DebuggerStepThrough] get; set; }

  protected override void ShowResultsExecute()
  {
    if (_CompilationFiles != null)
      CompilationFiles = new FileListViewModel(_CompilationFiles);
    if (_CompilationErrors != null)
      CompilationErrors = new ErrorListViewModel(_CompilationErrors);
    WindowsManager.ShowWindow<CodeResultsWindow>(this);
  }

  protected override void RefreshResultsExecute()
  {

  }

}
