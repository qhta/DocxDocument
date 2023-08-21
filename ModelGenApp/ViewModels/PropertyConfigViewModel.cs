namespace ModelGenApp.ViewModels;
public class PropertyConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalDeclarationType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalDeclarationTypeTooltip)
    )]
  public string OrigType
  {
    get { return _OrigType; }
    set
    {
      if (_OrigType != value)
      {
        _OrigType = value;
        NotifyPropertyChanged(nameof(OrigType));
      }
    }
  }
  private string _OrigType = string.Empty;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ConfigPropertyName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ConfigPropertyNameTooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedProperty),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedPropertyTooltip)
    )]
  public bool ExcludedProperty
  {
    get { return _Excluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(ExcludedProperty));
      }
    }
  }
  private bool _Excluded;

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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetPropertyType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetPropertyTypeTooltip)
    )]
  public string? TargetPropertyType
  {
    get { return _TargetPropertyType; }
    set
    {
      if (_TargetPropertyType != value)
      {
        _TargetPropertyType = value;
        NotifyPropertyChanged(nameof(TargetPropertyType));
      }
    }
  }
  private string? _TargetPropertyType;
  
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

}
