namespace ModelGenApp.ViewModels;
public class NamespaceConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    IsReadOnly = true,
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_name),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_name_tooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_namespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_namespace_tooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Shortcut),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Shortcut_tooltip)
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
    HiddenHeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ShortcutError),
    DataTemplateResourceKey ="ErrorMsgMarkTemplate"
    )]
  public string? ShortcutErrorMsg => IsShortcutValid ? (string?)null : CommonStrings.Duplicated_shortcut;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_name),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_name_tooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_shortcut),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_shortcut_tooltip)
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
    HiddenHeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetShortcutError),
    DataTemplateResourceKey ="ErrorMsgMarkTemplate"
    )]
  public string? TargetShortcutErrorMsg => IsTargetShortcutValid ? (string?)null : CommonStrings.Target_shortcut_error;

}
