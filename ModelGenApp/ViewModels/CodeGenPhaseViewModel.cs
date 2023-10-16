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
      if (summary.Summary.TryGetValue(TypeInfoKind.CompilationFileList, out var compilationFileList))
      {
        summary.Summary.Remove(TypeInfoKind.CompilationFileList);
        _CompilationFiles = (CompilationFiles)compilationFileList;
      }
      if (summary.Summary.TryGetValue(TypeInfoKind.CompilationErrorList, out var compilationErrorList))
      {
        summary.Summary.Remove(TypeInfoKind.CompilationErrorList);
        _CompilationErrors = (CompilationErrors)compilationErrorList;
      }
    }
    base.SetSummary(summary);
  }

  public FileListViewModel? CompilationFiles { get; set; }
  public ErrorListViewModel? CompilationErrors { get; set; }

  private CompilationFiles? _CompilationFiles { get; set; }
  private CompilationErrors? _CompilationErrors { get; set; }

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
