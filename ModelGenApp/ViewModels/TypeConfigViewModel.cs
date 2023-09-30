namespace ModelGenApp.ViewModels;
public class TypeConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalNamespaceTooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedNamespaceTooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalTypeName),
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedTypeTooltip)
    )]
  public bool IsExcluded
  {
    get { return _Excluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(IsExcluded));
      }
    }
  }
  private bool _Excluded;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.IncludedType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.IncludedTypeTooltip)
    )]
  public bool IsIncluded
  {
    get { return _Included; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(IsIncluded));
        if (value)
          IsExcluded = false;
      }
    }
  }
  private bool _Included;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetNamespaceTooltip)
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

}
