namespace DocxEd.ViewModels;
public class PropertyConfigViewModel : VisibleViewModel
{
  public PropertyConfigViewModel(TypeConfigViewModel parent, PropertyInfo property)
  {
    Parent = parent;
    Property = property;
    Parent.PropertyChanged += Parent_PropertyChanged;
  }

  public TypeConfigViewModel Parent { [DebuggerStepThrough] get; set; }
  public PropertyInfo Property { [DebuggerStepThrough] get; set; }

  private void Parent_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(TypeConfigViewModel.OrigNamespace))
      NotifyPropertyChanged(nameof(OrigNamespace));
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.OrigName))
      NotifyPropertyChanged(nameof(DeclaringType));
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.IsIncluded))
      NotifyPropertyChanged(nameof(IsIncluded));
    else
    if (args.PropertyName == nameof(TypeConfigViewModel.IsExcluded))
      NotifyPropertyChanged(nameof(IsExcluded));
  }

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.RecordNumber),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.RecordNumberTooltip)
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
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropertyNamespace),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropertyNamespaceTooltip)
    )]
  public string OrigNamespace => Parent.OrigNamespace;

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.DeclaringType),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.DeclaringTypeTooltip)
    )]
  public string DeclaringType => Parent.OrigName;

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropertyName),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropertyNameTooltip)
    )]
  public string OrigName => Property.Name;

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Accept),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.IncludedPropertyTooltip)
    )]
  public bool IsIncluded
  {
    [DebuggerStepThrough]
    get { return _Included ?? Parent.IsIncluded; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(IsIncluded));
        if (value)
          IsExcluded = false;
        if (value == Parent.IsIncluded)
          _Included = null;
      }
    }
  }
  private bool? _Included;

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Excl),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.ExcludedPropertyTooltip)
    )]
  public bool IsExcluded
  {
    [DebuggerStepThrough]
    get { return _Excluded ?? Parent.IsExcluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(IsExcluded));
        if (value)
          IsIncluded = false;
        if (value == Parent.IsExcluded)
          _Excluded = null;
      }
    }
  }
  private bool? _Excluded;


  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetPropertyName),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetPropertyNameTooltip)
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
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropValueNamespace),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropValueNamespaceTooltip)
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
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropValueType),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.OriginalPropValueTypeTooltip)
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
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.ExcludedValueType),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.ExcludedValueTypeTooltip)
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
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetPropertyType),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetPropertyTypeTooltip)
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
