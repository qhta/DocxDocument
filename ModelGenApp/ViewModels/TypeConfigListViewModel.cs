namespace ModelGenApp.ViewModels;
public class TypeConfigListViewModel : ConfigListViewModel
{
  public TypeConfigListViewModel(ModelConfigViewModel parent) : base(parent)
  {
    Caption = CommonStrings.ModelConfiguration + ": " + CommonStrings.Types.ToLower();
    Items = new ListViewModel<TypeConfigViewModel>();
    CollectionViewSource = new CollectionViewSource<TypeConfigViewModel>(Items);
    VisibleItems = CollectionViewSource.GetDefaultView(Items);
    ExcludeTypesCommand = new RelayCommand<string>(ExcludeTypesExecute, ExcludeTypesCanExecute) { Name = "ExcludeTypesCommand" };
    IncludeTypesCommand = new RelayCommand<string>(IncludeTypesExecute, IncludeTypesCanExecute) { Name = "IncludeTypesCommand" };
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
  private bool IsExcludedNamespaceChanged { get; set; }
  private bool IgnorePropertyChanged { get; set; }
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
        foreach (var item in Items)
          if (item.OrigNamespace == ns)
            item.ExcludedNamespace = value;
      }
    }
    IgnorePropertyChanged = false;
  }
  #endregion

  public ListViewModel<TypeConfigViewModel> Items { get; private set; }

  private CollectionViewSource<TypeConfigViewModel> CollectionViewSource;

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { get; private set; }

  public override void CreateItems(ModelConfigData configData)
  {
    Items.Clear();
    var fullNameComparison = configData.IncludedTypes.FirstOrDefault(item => item.Contains('.')) != null
                          || configData.ExcludedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    foreach (var type in Parent.LoadedTypes)
    {
      if (type != null)
      {
        var fullTypeName = (type.Namespace ?? "") + "." + type.Name;

        var item = new TypeConfigViewModel { OrigNamespace = type.Namespace ?? "", OrigName = type.Name };
        if (type.IsEnum)
          item.TypeKind = TypeKind.@enum;
        else
        if (type.IsValueType)
          item.TypeKind = TypeKind.@struct;
        else if (type.IsInterface)
          item.TypeKind = TypeKind.@interface;
        else
          item.TypeKind = TypeKind.@class;
        item.ExcludedNamespace = configData.ExcludedNamespaces.Contains(type.Namespace ?? "");
        if (fullNameComparison)
        {
          item.IsExcluded = configData.ExcludedTypes.Contains(fullTypeName);
          item.IsIncluded = configData.IncludedTypes.Contains(fullTypeName);
        }
        else
        {
          item.IsExcluded = configData.ExcludedTypes.Contains(type.Name);
          item.IsIncluded = configData.IncludedTypes.Contains(type.Name);
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
        Items.Add(item);
      }
    }
  }

  public override void SetData(ModelConfigData configData)
  {
    if (IsExcludedNamespaceChanged)
    {
      configData.ExcludedNamespaces.Clear();
      foreach (var nsGrouping in Items.Where(item => item.ExcludedNamespace).GroupBy(item => item.OrigNamespace))
        configData.ExcludedNamespaces.Add(nsGrouping.Key);
    }
    configData.IncludedTypes.Clear();
    configData.ExcludedTypes.Clear();
    configData.TypeConversion.Clear();
    foreach (var item in Items)
    {
      var fullTypeName = item.OrigNamespace + "." + item.OrigName;
      if (item.IsIncluded)
        configData.IncludedTypes.Add(fullTypeName);
      if (item.IsExcluded)
        configData.ExcludedTypes.Add(fullTypeName);
      if (item.TargetNamespace != null || item.TargetName != null)
      {
        var targetNamespace = item.TargetNamespace ?? item.OrigNamespace.Replace("DocumentFormat.OpenXml", "DocumentModel");
        var targetName = item.TargetName ?? item.OrigName;
        configData.TypeConversion.Add(fullTypeName, targetNamespace + "." + targetName);
      }
    }
  }

  public override bool ValidateData()
  {
    var ok = true;
    return ok;
  }

  #region ExcludeTypesCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command ExcludeTypesCommand { get; private set; }

  protected virtual void ExcludeTypesExecute(string? parameter)
  {
    if (parameter != null)
      foreach (var item in Items)
      {
        if (item.OrigName.IsLike(parameter))
          item.IsExcluded = true;
      }
  }

  protected virtual bool ExcludeTypesCanExecute(string? parameter)
  {
    return !String.IsNullOrEmpty(parameter);
  }
  #endregion

  #region IncludeTypesCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command IncludeTypesCommand { get; private set; }

  protected virtual void IncludeTypesExecute(string? parameter)
  {
    if (parameter != null)
      foreach (var item in Items)
      {
        if (item.OrigName.IsLike(parameter))
          item.IsIncluded = true;
      }
  }

  protected virtual bool IncludeTypesCanExecute(string? parameter)
  {
    return !String.IsNullOrEmpty(parameter);
  }
  #endregion


}
