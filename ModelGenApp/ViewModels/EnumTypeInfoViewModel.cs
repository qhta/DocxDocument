namespace ModelGenApp.ViewModels;

public class EnumTypeInfoViewModel : TypeInfoViewModel
{
  public EnumTypeInfoViewModel(TypeInfo typeInfo, bool original) : base(typeInfo, original)
  {
    _EnumValues = new EnumListViewModel(this, "Enum values");
  }

  [DataGridColumn(Header = "Enum values")]
  public EnumListViewModel EnumValues
  {
    get { return _EnumValues; }
    set
    {
      if (_EnumValues != value)
      {
        _EnumValues = value;
        NotifyPropertyChanged(nameof(EnumValues));
      }
    }
  }
  private EnumListViewModel _EnumValues;
}
