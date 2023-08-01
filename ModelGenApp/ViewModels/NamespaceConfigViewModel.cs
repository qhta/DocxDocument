namespace ModelGenApp.ViewModels;
public class NamespaceConfigViewModel : ViewModel, IEditableObject
{

  public string OrigName
  {
    get { return _OrigName; }
    set
    {
      if (_OrigName != value)
      {
        _OrigName = value;
        NotifyPropertyChanged(nameof(OrigName));
      }
    }
  }
  private string _OrigName = string.Empty;

  public bool Excluded
  {
    get { return _Excluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(Excluded));
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

  public bool IsShortcutValid
  {
    get { return _IsShortcutValid; }
    set
    {
      if (_IsShortcutValid != value)
      {
        _IsShortcutValid = value;
        NotifyPropertyChanged(nameof(IsShortcutValid));
      }
    }
  }
  private bool _IsShortcutValid = true;

  public string? ShortcutErrorMsg
  {
    get { return _ShortcutErrorMsg; }
    set
    {
      if (_ShortcutErrorMsg != value)
      {
        _ShortcutErrorMsg = value;
        NotifyPropertyChanged(nameof(ShortcutErrorMsg));
      }
    }
  }
  private string? _ShortcutErrorMsg;

  public string? TargetName
  {
    get { return _TargetName; }
    set
    {
      if (_TargetName != value)
      {
        _TargetName = value;
        NotifyPropertyChanged(nameof(TargetName));
      }
    }
  }
  private string? _TargetName;

  public string? TargetShortcut
  {
    get { return _TargetShortcut; }
    set
    {
      if (_TargetShortcut != value)
      {
        _TargetShortcut = value;
        NotifyPropertyChanged(nameof(TargetShortcut));
      }
    }
  }
  private string? _TargetShortcut;

  public bool IsTargetShortcutValid
  {
    get { return _IsTargetShortcutValid; }
    set
    {
      if (_IsTargetShortcutValid != value)
      {
        _IsTargetShortcutValid = value;
        NotifyPropertyChanged(nameof(IsTargetShortcutValid));
      }
    }
  }
  private bool _IsTargetShortcutValid = true;

  public string? TargetShortcutErrorMsg
  {
    get { return _TargetShortcutErrorMsg; }
    set
    {
      if (_TargetShortcutErrorMsg != value)
      {
        _TargetShortcutErrorMsg = value;
        NotifyPropertyChanged(nameof(TargetShortcutErrorMsg));
      }
    }
  }
  private string? _TargetShortcutErrorMsg;

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
