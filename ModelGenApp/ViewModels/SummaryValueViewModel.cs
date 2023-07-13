namespace ModelGenApp.ViewModels;
public class SummaryValueViewModel: ViewModel
{
  public SummaryInfoKind InfoKind { get; set; }

  public string Name { get; set; } = null!;

  public object? Value { get; set; }

  public bool IsChecked
  {
    get { return _IsChecked; }
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
}
