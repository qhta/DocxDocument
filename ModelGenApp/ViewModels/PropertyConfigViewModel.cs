namespace ModelGenApp.ViewModels;
public class PropertyConfigViewModel : VisibleViewModel
{
  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.RecordNumber),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.RecordNumberTooltip)
    )]
  public int RecordNumber
  {
   [DebuggerStepThrough] get { return _RecordNumber; }
    set
    {
      if (_RecordNumber != value)
      {
        _RecordNumber = value;
        NotifyPropertyChanged(nameof(RecordNumber));
      }
    }
  }
  private int _RecordNumber;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropertyNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropertyNamespaceTooltip)
    )]
  public string OrigNamespace
  {
   [DebuggerStepThrough] get { return _OrigNamespace; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropertyType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropertyTypeTooltip)
    )]
  public string OrigType
  {
   [DebuggerStepThrough] get { return _OrigType; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropertyName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropertyNameTooltip)
    )]
  public string OrigName
  {
   [DebuggerStepThrough] get { return _OrigName; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetPropertyName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetPropertyNameTooltip)
    )]
  public string? TargetName
  {
   [DebuggerStepThrough] get { return _TargetName; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedPropertyNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedPropertyNamespaceTooltip)
    )]
  public bool ExcludedNamespace
  {
   [DebuggerStepThrough] get { return _ExcludedNamespace; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedPropertyType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedPropertyTypeTooltip)
    )]
  public bool ExcludedType
  {
   [DebuggerStepThrough] get { return _ExcludedType; }
    set
    {
      if (_ExcludedType != value)
      {
        _ExcludedType = value;
        NotifyPropertyChanged(nameof(ExcludedType));
      }
    }
  }
  private bool _ExcludedType;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedProperty),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedPropertyTooltip)
    )]
  public bool ExcludedProperty
  {
   [DebuggerStepThrough] get { return _ExcludedProperty; }
    set
    {
      if (_ExcludedProperty != value)
      {
        _ExcludedProperty = value;
        NotifyPropertyChanged(nameof(ExcludedProperty));
      }
    }
  }
  private bool _ExcludedProperty;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropValueNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropValueNamespaceTooltip)
    )]
  public string OrigValueNamespace
  {
   [DebuggerStepThrough] get { return _OrigValueNamespace; }
    set
    {
      if (_OrigValueNamespace != value)
      {
        _OrigValueNamespace = value;
        NotifyPropertyChanged(nameof(OrigValueNamespace));
      }
    }
  }
  private string _OrigValueNamespace = string.Empty;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropValueType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.OriginalPropValueTypeTooltip)
    )]
  public string OrigValueType
  {
   [DebuggerStepThrough] get { return _OrigValueType; }
    set
    {
      if (_OrigValueType != value)
      {
        _OrigValueType = value;
        NotifyPropertyChanged(nameof(OrigValueType));
      }
    }
  }
  private string _OrigValueType = string.Empty;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedValueType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.ExcludedValueTypeTooltip)
    )]
  public bool ExcludedValueType
  {
   [DebuggerStepThrough] get { return _ExcludedValueType; }
    set
    {
      if (_ExcludedValueType != value)
      {
        _ExcludedValueType = value;
        NotifyPropertyChanged(nameof(ExcludedValueType));
      }
    }
  }
  private bool _ExcludedValueType;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetPropertyType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.TargetPropertyTypeTooltip)
    )]
  public string? TargetPropertyType
  {
   [DebuggerStepThrough] get { return _TargetPropertyType; }
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
   [DebuggerStepThrough] get { return _IsValid; }
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
   [DebuggerStepThrough] get { return _ValidationMsg; }
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
