namespace ModelGenApp.ViewModels;

public class ClassInfoViewModel : TypeInfoViewModel
{
  public ClassInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo, original)
  {
    _Properties = new PropListViewModel(this, "Properties");
  }

  public PropListViewModel Properties
  {
    get { return _Properties; }
    set
    {
      if (_Properties != value)
      {
        _Properties = value;
        NotifyPropertyChanged(nameof(Properties));
      }
    }
  }
  private PropListViewModel _Properties;
}
