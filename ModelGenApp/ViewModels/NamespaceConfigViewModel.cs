namespace ModelGenApp.ViewModels;
public class NamespaceConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    IsReadOnly = true,
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalNameTooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedNamespaceTooltip)
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
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ShortcutTooltip)
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
        NotifyPropertyChanged(nameof(ShortcutError));
      }
    }
  }
  private bool _IsShortcutValid = true;

  [DataGridColumn(
    Header = "",
    HiddenHeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ShortcutError),
    DataTemplateResourceKey ="ErrorMsgMarkTemplate"
    )]
  public string? ShortcutError => IsShortcutValid ? (string?)null : CommonStrings.Duplicated_shortcut;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetNameTooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetShortcut),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetShortcutTooltip)
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
        NotifyPropertyChanged(nameof(TargetShortcutError));
      }
    }
  }
  private bool _IsTargetShortcutValid = true;

  [DataGridColumn(
    Header = "",
    HiddenHeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetShortcutError),
    DataTemplateResourceKey ="ErrorMsgMarkTemplate"
    )]
  public string? TargetShortcutError => IsTargetShortcutValid ? (string?)null : CommonStrings.Target_shortcut_error;

}
