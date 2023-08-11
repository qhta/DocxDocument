namespace ModelGenApp.ViewModels;
public class TypeConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.OriginalNamespace",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.OriginalNamespaceTooltip"
    )]
  public string OrigNamespace
  {
    get { return _OrigNamespace; }
    set
    {
      if (_OrigNamespace != value)
      {
        _OrigNamespace = value;
        NotifyPropertyChanged(nameof(OrigNamespace));
      }
    }
  }
  private string _OrigNamespace = string.Empty;


  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.ExcludedNamespace",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.ExcludedNamespaceTooltip"
    )]
  public bool ExcludedNamespace
  {
    get { return _ExcludedNamespace; }
    set
    {
      if (_ExcludedNamespace != value)
      {
        _ExcludedNamespace = value;
        NotifyPropertyChanged(nameof(ExcludedNamespace));
      }
    }
  }
  private bool _ExcludedNamespace;

  [DataGridColumn(
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
    HeaderResourceKey = "ModelGenApp.CommonStrings.IncludedType",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.IncludedTypeTooltip"
    )]
  public bool IncludedType
  {
    get { return _Included; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(IncludedType));
        if (value)
          ExcludedType = false;
      }
    }
  }
  private bool _Included;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.ExcludedType",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.ExcludedTypeTooltip"
    )]
  public bool ExcludedType
  {
    get { return _Excluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(ExcludedType));
      }
    }
  }
  private bool _Excluded;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings.TargetNamespace",
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings.TargetNamespaceTooltip"
    )]
  public string? TargetNamespace
  {
    get { return _TargetNamespace; }
    set
    {
      if (_TargetNamespace != value)
      {
        _TargetNamespace = value;
        NotifyPropertyChanged(nameof(TargetNamespace));
      }
    }
  }
  private string? _TargetNamespace;

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

}
