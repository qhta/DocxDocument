namespace DocxEd.ViewModels;
public class TypePropViewModel: ViewModel
{
  public TypePropViewModel(string propName, object? value)
  {
    Name = propName;
    Value = value;
  }

  public string Name { [DebuggerStepThrough] get; set; }

  public object? Value { [DebuggerStepThrough] get; set; }

  public bool IsRed
  {
   [DebuggerStepThrough] get { return _IsRed; }
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
