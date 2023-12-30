namespace ModelGenApp.ViewModels;
public class PropertyConfigViewModel : VisibleViewModel
{
  public PropertyConfigViewModel(TypeConfigViewModel parent, PropertyInfo property)
  {
    Parent = parent;
    Property = property;
    Parent.PropertyChanged += Parent_PropertyChanged;
  }


  private TypeConfigViewModel Parent { [DebuggerStepThrough] get; set; }
  private PropertyInfo Property { [DebuggerStepThrough] get; set; }

  private void Parent_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(TypeConfigViewModel.OrigNamespace))
      NotifyPropertyChanged(nameof(OrigNamespace));
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.OrigName))
      NotifyPropertyChanged(nameof(OrigTypeName));
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.Excluded))
      NotifyPropertyChanged(nameof(IsTypeExcluded));
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.RecordNumber),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.RecordNumberTooltip)
    )]
  public int RecordNumber
  {
    [DebuggerStepThrough]
    get { return _RecordNumber; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropertyNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropertyNamespaceTooltip)
    )]
  public string OrigNamespace => Parent.OrigNamespace;

  public string OrigTypeName => Parent.OrigName;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropertyName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropertyNameTooltip)
    )]
  public string OrigName => Property.Name;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetPropertyName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetPropertyNameTooltip)
    )]
  public string? TargetName
  {
    [DebuggerStepThrough]
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedPropertyType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedPropertyTypeTooltip)
    )]
  public bool IsTypeExcluded => Parent.Excluded;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedProperty),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedPropertyTooltip)
    )]
  public bool ExcludedProperty
  {
    [DebuggerStepThrough]
    get { return _ExcludedProperty; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropValueNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropValueNamespaceTooltip)
    )]
  public string OrigValueNamespace
  {
    [DebuggerStepThrough]
    get { return _OrigValueNamespace; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropValueType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalPropValueTypeTooltip)
    )]
  public string OrigValueType
  {
    [DebuggerStepThrough]
    get { return _OrigValueType; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedValueType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedValueTypeTooltip)
    )]
  public bool ExcludedValueType
  {
    [DebuggerStepThrough]
    get { return _ExcludedValueType; }
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetPropertyType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetPropertyTypeTooltip)
    )]
  public string? TargetPropertyType
  {
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
    [DebuggerStepThrough]
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
