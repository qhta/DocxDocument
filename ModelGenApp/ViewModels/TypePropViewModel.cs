namespace ModelGenApp.ViewModels;
public class TypePropViewModel: ViewModel
{
  public TypePropViewModel(string propName, object? value)
  {
    Name = propName;
    Value = value;
  }

  public string Name { get; set; }

  public object? Value { get; set; }

  public bool IsRed
  {
    get { return _IsRed; }
    set
    {
      if (_IsRed != value)
      {
        _IsRed = value;
        NotifyPropertyChanged(nameof(IsRed));
      }
    }
  }
  private bool _IsRed;
}
