using System.ComponentModel;

namespace ModelGenApp.ViewModels;
public class NamespaceConfigViewModel : ViewModel, IEditableObject
{

  public string Name
  {
    get { return _OrigName; }
    set
    {
      if (_OrigName != value)
      {
        _OrigName = value;
        NotifyPropertyChanged(nameof(Name));
      }
    }
  }
  private string _OrigName = string.Empty;

  public bool Included
  {
    get { return _Included; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(Included));
        if (value)
          Excluded = false;
      }
    }
  }
  private bool _Included;

  public bool Excluded
  {
    get { return _Excluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(Excluded));
        if (value)
          Included = false;
       }
    }
  }
  private bool _Excluded;


  public string? Prefix
  {
    get { return _Prefix; }
    set
    {
      if (_Prefix != value)
      {
        _Prefix = value;
        NotifyPropertyChanged(nameof(Prefix));
      }
    }
  }
  private string? _Prefix;


  public string? TranslatedName
  {
    get { return _TranslatedName; }
    set
    {
      if (_TranslatedName != value)
      {
        _TranslatedName = value;
        NotifyPropertyChanged(nameof(TranslatedName));
      }
    }
  }
  private string? _TranslatedName;

  public void BeginEdit()
  {
    //throw new NotImplementedException();
  }

  public void CancelEdit()
  {
    //throw new NotImplementedException();
  }

  public void EndEdit()
  {
    //throw new NotImplementedException();
  }
}
