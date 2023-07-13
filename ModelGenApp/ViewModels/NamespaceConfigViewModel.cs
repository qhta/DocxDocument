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

  public string? Shortcut
  {
    get { return _Shortcut; }
    set
    {
      if (_Shortcut != value)
      {
        _Shortcut = value;
        NotifyPropertyChanged(nameof(Shortcut));
      }
    }
  }
  private string? _Shortcut;

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

  public string? TranslatedShortcut
  {
    get { return _TranslatedShortcut; }
    set
    {
      if (_TranslatedShortcut != value)
      {
        _TranslatedShortcut = value;
        NotifyPropertyChanged(nameof(TranslatedShortcut));
      }
    }
  }
  private string? _TranslatedShortcut;

  public new bool IsValid
  {
    get { return _IsValid; }
    set
    {
      if (_IsValid != value)
      {
        _IsValid = value;
        NotifyPropertyChanged(nameof(IsValid));
      }
    }
  }
  private bool _IsValid = true;

  public string? ValidationMsg
  {
    get { return _ValidationMsg; }
    set
    {
      if (_ValidationMsg != value)
      {
        _ValidationMsg = value;
        NotifyPropertyChanged(nameof(ValidationMsg));
      }
    }
  }
  private string? _ValidationMsg;

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
