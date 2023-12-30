namespace ModelGenApp.ViewModels;
public class PhaseSummaryInfoViewModel: ViewModel
{
  public SummaryInfoKind InfoKind { [DebuggerStepThrough] get; set; }

  public string Name { [DebuggerStepThrough] get; set; } = null!;

  public object? Value { [DebuggerStepThrough] get; set; }

  public bool IsChecked
  {
   [DebuggerStepThrough] get { return _IsChecked; }
    set
    {
      if (_IsChecked != value)
      {
        _IsChecked = value;
        NotifyPropertyChanged(nameof(IsChecked));
      }
    }
  }
  private bool _IsChecked;

  public bool FilterEnabled { [DebuggerStepThrough] get; set; }
}
