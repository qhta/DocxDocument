namespace ModelGenApp.ViewModels;
public class PropertyConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_declaration_type),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_declaration_type_tooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Config_property_name),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Config_property_name_tooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_property),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_property_tooltip)
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_property_type),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_property_type_tooltip)
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
