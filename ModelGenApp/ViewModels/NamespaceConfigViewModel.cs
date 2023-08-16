namespace ModelGenApp.ViewModels;
public class NamespaceConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    IsReadOnly = true,
    HeaderResourceKey = "ModelGenApp.CommonStrings.OriginalName",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.OriginalNameTooltip"
    )]
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

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.ExcludedNamespace",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.ExcludedNamespaceTooltip",
    ShowFilterButtonEnabled = false
    )]
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

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.Shortcut",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.ShortcutTooltip"
    )]
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
    get => _IsShortcutValid;
    set
    {
      if (_IsShortcutValid != value)
      {
        _IsShortcutValid = value;
        NotifyPropertyChanged(nameof(IsShortcutValid));
        NotifyPropertyChanged(nameof(ShortcutErrorMsg));
      }
    }
  }
  private bool _IsShortcutValid = true;

  [DataGridColumn(
    Header = "",
    DataTemplateResourceKey ="ErrorMsgMarkTemplate"
    )]
  public string? ShortcutErrorMsg => IsShortcutValid ? (string?)null : CommonStrings.ShortcutErrorMsg;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.TargetName",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.TargetNameTooltip"
    )]
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

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.TargetShortcut",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.TargetShortcutTooltip"
    )]
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
        NotifyPropertyChanged(nameof(TargetShortcutErrorMsg));
      }
    }
  }
  private bool _IsTargetShortcutValid = true;

  [DataGridColumn(
    Header = "",
    DataTemplateResourceKey ="ErrorMsgMarkTemplate"
    )]
  public string? TargetShortcutErrorMsg => IsTargetShortcutValid ? (string?)null : CommonStrings.TargetShortcutErrorMsg;

}
