﻿namespace ModelGenApp.ViewModels;
public class TypeConfigViewModel : VisibleViewModel
{
  public TypeConfigViewModel(NamespaceConfigViewModel parent, Type type)
  {
    Parent = parent;
    Type = type;
    Parent.PropertyChanged += Parent_PropertyChanged;
  }


  public NamespaceConfigViewModel Parent { [DebuggerStepThrough] get; private set; }
  public Type Type { [DebuggerStepThrough] get; private set; }

  private void Parent_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(NamespaceConfigViewModel.OrigName))
      NotifyPropertyChanged(nameof(OrigNamespace));
    else if (args.PropertyName == nameof(NamespaceConfigViewModel.IsAccepted))
      NotifyPropertyChanged(nameof(IsIncluded));
    else
    if (args.PropertyName == nameof(NamespaceConfigViewModel.IsRejected))
      NotifyPropertyChanged(nameof(IsExcluded));
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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalNamespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalNamespaceTooltip)
    )]
  public string OrigNamespace => Parent.OrigName;

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
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Accept),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IncludedTypeTooltip)
    )]
  public bool IsIncluded
  {
    [DebuggerStepThrough]
    get { return _Included ?? Parent.IsAccepted; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(IsIncluded));
        if (value)
          IsExcluded = false;
        if (value == Parent.IsAccepted)
          _Included = null;
      }
    }
  }
  private bool? _Included;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Excl),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.ExcludedTypeTooltip)
    )]
  public bool IsExcluded
  {
    [DebuggerStepThrough]
    get { return _Excluded ?? Parent.IsRejected; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(IsExcluded));
        if (value)
          IsIncluded = false;
        if (value == Parent.IsRejected)
          _Excluded = null;
      }
    }
  }
  private bool? _Excluded;


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
