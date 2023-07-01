namespace ModelGenApp.ViewModels;
public class SummaryValueViewModel: ViewModel
{

  public new string Name
  {
    get { return _Name; }
    set
    {
      if (_Name != value)
      {
        _Name = value;
        NotifyPropertyChanged(nameof(Name));
      }
    }
  }
  private string _Name = null!;


  public object? Value
  {
    get { return _Value; }
    set
    {
      if (_Value != value)
      {
        _Value = value;
        NotifyPropertyChanged(nameof(Value));
      }
    }
  }
  private object? _Value;


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
  private bool _IsChecked = true;
}
