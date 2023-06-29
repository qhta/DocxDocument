namespace ModelGenApp.ViewModels;
public class NamespaceViewModel: ViewModel
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


  public int AllTypesCount
  {
    get { return _AllTypesCount; }
    set
    {
      if (_AllTypesCount != value)
      {
        _AllTypesCount = value;
        NotifyPropertyChanged(nameof(_AllTypesCount));
      }
    }
  }
  private int _AllTypesCount;


  public int ClassesCount
  {
    get { return _ClassesCount; }
    set
    {
      if (_ClassesCount != value)
      {
        _ClassesCount = value;
        NotifyPropertyChanged(nameof(ClassesCount));
      }
    }
  }
  private int _ClassesCount;


  public int InterfacesCount
  {
    get { return _InterfacesCount; }
    set
    {
      if (_InterfacesCount != value)
      {
        _InterfacesCount = value;
        NotifyPropertyChanged(nameof(InterfacesCount));
      }
    }
  }
  private int _InterfacesCount;


  public int EnumTypesCount
  {
    get { return _EnumTypesCount; }
    set
    {
      if (_EnumTypesCount != value)
      {
        _EnumTypesCount = value;
        NotifyPropertyChanged(nameof(EnumTypesCount));
      }
    }
  }
  private int _EnumTypesCount;


  public int OtherTypesCount
  {
    get { return _OtherTypesCount; }
    set
    {
      if (_OtherTypesCount != value)
      {
        _OtherTypesCount = value;
        NotifyPropertyChanged(nameof(OtherTypesCount));
      }
    }
  }
  private int _OtherTypesCount;
}
