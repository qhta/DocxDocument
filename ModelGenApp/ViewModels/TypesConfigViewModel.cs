namespace ModelGenApp.ViewModels;
public class TypesConfigViewModel : ModelConfigViewModel
{
  public TypesConfigViewModel(ModelConfig configData) : base(configData)
  {
    Caption = CommonStrings.ModelConfiguration+": "+CommonStrings.Types.ToLower();
    Types = new ListViewModel<TypeConfigViewModel>();
    Types.CollectionChanged += Types_CollectionChanged;
    VisibleItems = new FilteredCollection<TypeConfigViewModel>(Types);
    GetData(configData);
  }

  #region Populate ExcludedNamespace for all items on change of one
  private void Types_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
      if (args.NewItems != null)
        foreach (var item in args.NewItems)
        {
          if (item is TypeConfigViewModel typeConfigViewModel)
            typeConfigViewModel.PropertyChanged += TypeConfigViewModel_PropertyChanged;
        }
    }
  }

  private bool IsExcludedNamespaceChanged;
  private bool IgnorePropertyChanged;
  private void TypeConfigViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (IgnorePropertyChanged) return;
    IgnorePropertyChanged = true;
    if (sender is TypeConfigViewModel typeConfigViewModel)
    {
      IsExcludedNamespaceChanged = true;
      if (args.PropertyName == nameof(TypeConfigViewModel.ExcludedNamespace))
      {
        var value = typeConfigViewModel.ExcludedNamespace;
        var ns = typeConfigViewModel.OrigNamespace;
        foreach (var item in Types)
          if (item.OrigNamespace == ns)
            item.ExcludedNamespace = value;
      }
    }
    IgnorePropertyChanged = false;
  }
  #endregion

  public ListViewModel<TypeConfigViewModel> Types { get; private set; }

  public FilteredCollection<TypeConfigViewModel> VisibleItems { get; private set; }

  public override void GetData(ModelConfig configData)
  {
    base.GetData(configData);
    var types = _Assembly.GetExportedTypes()
      .OrderBy(ti => ti.Name)
      .ToList();
    var fullNameComparison = configData.IncludedTypes.FirstOrDefault(item => item.Contains('.')) != null
                          || configData.ExcludedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    foreach (var type in types)
    {
      if (type != null)
      {
        var fullTypeName = (type.Namespace ?? "") + "." + type.Name;

        var item = new TypeConfigViewModel { OrigNamespace = type.Namespace ?? "", OrigName = type.Name };
        item.ExcludedNamespace = configData.ExcludedNamespaces.Contains(type.Namespace ?? "");
        if (fullNameComparison)
        {
          item.ExcludedType = configData.ExcludedTypes.Contains(fullTypeName);
          item.IncludedType = configData.IncludedTypes.Contains(fullTypeName);
        }
        else
        {
          item.ExcludedType = configData.ExcludedTypes.Contains(type.Name);
          item.IncludedType = configData.IncludedTypes.Contains(type.Name);
        }
        if (configData.TypeConversion.TryGetValue(fullTypeName, out var conversion))
        {
          var k = conversion.LastIndexOf('.');
          if (k > 0 && k < conversion.Length - 1)
          {
            item.TargetNamespace = conversion.Substring(0, k);
            item.TargetName = conversion.Substring(k + 1);
          }
        }
        Types.Add(item);
      }
    }
  }

  public override void SetData(ModelConfig configData)
  {
    if (IsExcludedNamespaceChanged)
    {
      configData.ExcludedNamespaces.Clear();
      foreach (var nsGrouping in Types.Where(item => item.ExcludedNamespace).GroupBy(item => item.OrigNamespace))
        configData.ExcludedNamespaces.Add(nsGrouping.Key);
    }
    configData.IncludedTypes.Clear();
    configData.ExcludedTypes.Clear();
    configData.TypeConversion.Clear();
    foreach (var item in Types)
    {
      var fullTypeName = item.OrigNamespace + "." + item.OrigName;
      if (item.IncludedType)
        configData.IncludedTypes.Add(fullTypeName);
      if (item.ExcludedType)
        configData.ExcludedTypes.Add(fullTypeName);
      if (item.TargetNamespace != null && item.TargetName != null)
        configData.TypeConversion.Add(fullTypeName, item.TargetNamespace + "." + item.TargetName);
    }
  }

  public override bool ValidateData()
  {
    var ok = true;
    return ok;
  }

}
