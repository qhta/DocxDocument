namespace ModelGenApp.ViewModels;
public class TypePropViewModel: ViewModel
{
  public TypePropViewModel(string propName, object? value, bool invalid=false)
  {
    Name = propName;
    if (invalid)
    {
      var str = value?.ToString();
      if (str != null)
        Value = new ErrString(str);
    }
    else
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
