namespace ModelGenApp.ViewModels;
public class SummaryValueViewModel: ViewModel
{

  public string Name
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
}
