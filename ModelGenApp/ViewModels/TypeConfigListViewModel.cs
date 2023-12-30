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
  private bool IsExcludedNamespaceChanged { [DebuggerStepThrough] get; set; }
  private bool IgnorePropertyChanged { [DebuggerStepThrough] get; set; }
  private void TypeConfigViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    //if (IgnorePropertyChanged) return;
    //IgnorePropertyChanged = true;
    //if (sender is TypeConfigViewModel typeConfigViewModel)
    //{
    //  IsExcludedNamespaceChanged = true;
    //  if (args.PropertyName == nameof(TypeConfigViewModel.IsNamespaceExcluded))
    //  {
    //    var value = typeConfigViewModel.IsNamespaceExcluded;
    //    var ns = typeConfigViewModel.OrigNamespace;
    //    foreach (var item in Items)
    //      if (item.OrigNamespace == ns)
    //        item.NamespaceExcluded = value;
    //  }
    //}
    //IgnorePropertyChanged = false;
  }
  #endregion

  public ListViewModel<TypeConfigViewModel> Items { [DebuggerStepThrough] get; private set; }

  private CollectionViewSource<TypeConfigViewModel> CollectionViewSource;

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { [DebuggerStepThrough] get; private set; }

  public void ClearItems()
  {
    Items.Clear();
  }

  public void CreateItems(NamespaceConfigViewModel nsVM, ModelConfigData configData)
  {
    var fullNameComparison = configData.IncludedTypes.FirstOrDefault(item => item.Contains('.')) != null
                          || configData.ExcludedTypes.FirstOrDefault(item => item.Contains('.')) != null;
    foreach (var type in Parent.LoadedTypes)
    {
      if (type != null)
      {
        var fullTypeName = (type.Namespace ?? "") + "." + type.Name;

        var item = new TypeConfigViewModel (nsVM, type);
        if (fullNameComparison)
        {
          item.Excluded = configData.ExcludedTypes.Contains(fullTypeName);
          item.IsIncluded = configData.IncludedTypes.Contains(fullTypeName);
        }
        else
        {
          item.Excluded = configData.ExcludedTypes.Contains(type.Name);
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
      foreach (var nsGrouping in Items.Where(item => item.IsNamespaceExcluded).GroupBy(item => item.OrigNamespace))
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
      if (item.Excluded)
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
  public Command ExcludeTypesCommand { [DebuggerStepThrough] get; private set; }

  protected virtual void ExcludeTypesExecute(string? parameter)
  {
    if (parameter != null)
      foreach (var item in Items)
      {
        if (item.OrigName.IsLike(parameter))
          item.Excluded = true;
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
  public Command IncludeTypesCommand { [DebuggerStepThrough] get; private set; }

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
