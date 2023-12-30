namespace ModelGenApp.ViewModels;
public class TypeConfigViewModel : VisibleViewModel
{
  public TypeConfigViewModel(NamespaceConfigViewModel parent, Type type)
  {
    Parent = parent;
    Type = type;
    Parent.PropertyChanged += Parent_PropertyChanged;
  }


  private NamespaceConfigViewModel Parent { [DebuggerStepThrough] get; set; }
  private Type Type { [DebuggerStepThrough] get; set; }

  private void Parent_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(NamespaceConfigViewModel.OrigName))
      NotifyPropertyChanged(nameof(OrigNamespace));
    else if (args.PropertyName == nameof(NamespaceConfigViewModel.IsIncluded))
      NotifyPropertyChanged(nameof(IsNamespaceIncluded));
    else
    if (args.PropertyName == nameof(NamespaceConfigViewModel.IsExcluded))
      NotifyPropertyChanged(nameof(IsNamespaceExcluded));
  }


  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalNamespaceTooltip)
    )]
  public string OrigNamespace => Parent.OrigName;

  [DataGridColumn(
  HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IncludedNamespace),
  HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IncludedNamespaceTooltip)
  )]
  public bool IsNamespaceIncluded => Parent.IsIncluded;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedNamespaceTooltip)
    )]
  public bool IsNamespaceExcluded => Parent.IsExcluded;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TypeKind),
    IsReadOnly = true
    )]
  public TypeKind TypeKind => TypeManager.GetTypeKind(Type);

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalTypeName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalNameTooltip)
    )]
  public string OrigName => Type.Name; 

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedTypeTooltip)
    )]
  public bool Excluded
  {
    [DebuggerStepThrough]
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

  public bool IsExcluded => Excluded || IsNamespaceExcluded;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IncludedType),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IncludedTypeTooltip)
    )]
  public bool IsIncluded
  {
    [DebuggerStepThrough]
    get { return _Included; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(IsIncluded));
        if (value)
          Excluded = false;
      }
    }
  }
  private bool _Included;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetNamespaceTooltip)
    )]
  public string? TargetNamespace
  {
    [DebuggerStepThrough]
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetNameTooltip)
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

}
