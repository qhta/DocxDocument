namespace ModelGenApp.ViewModels;
public class TypeListViewModel : ViewModel
{
  public TypeListViewModel(PhaseViewModel phase, NamespaceViewModel? nspace, string name,
    TNS typeNameSelector, TKS typeKindSelector, TypeInfoFilter? filter, TypeListViewModel? source = null)
  {
    Namespace = nspace;
    Name = name;
    Filter = filter;
    if (Items is INotifyCollectionChanged observableCollection)
      observableCollection.CollectionChanged += Items_CollectionChanged;
    TypeNameSelector = typeNameSelector;
    TypeKindSelector = typeKindSelector;
    Phase = phase;
    Source = source;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
    RefreshResultsCommand = new RelayCommand(RefreshResultsExecute, RefreshResultsCanExecute) { Name = "RefreshResultsCommand" };
  }

  private void Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
  {
    NotifyPropertyChanged(nameof(Count));
    ShowDetailsCommand?.NotifyCanExecuteChanged();
  }

  //public TypeListViewModel(PhaseViewModel phase, NamespaceViewModel? nspace, string name, TNS typeNameSelector, IEnumerable<TypeInfoViewModel> source)
  //{
  //  Namespace = nspace;
  //  Name = name;
  //  AddRange(source);
  //  if (Items is INotifyCollectionChanged observableCollection)
  //    observableCollection.CollectionChanged += Items_CollectionChanged;
  //  TypeNameSelector = typeNameSelector;
  //  Phase = phase;
  //  ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  //  RefreshResultsCommand = new RelayCommand(RefreshResultsExecute, RefreshResultsCanExecute) { Name = "RefreshResultsCommand" };
  //}

  protected virtual void AddRange(IEnumerable<TypeInfoViewModel> list)
  {
    (Items as ObservableList<TypeInfoViewModel>)?.AddRange(list);
  }
  public NamespaceViewModel? Namespace { get; private set; }

  public string Name { get; private set; }

  public string Caption
  {
    get
    {
      string? result = null;
      if (Namespace != null)
        result = Namespace.Caption + ": ";
      result += (CommonStrings.ResourceManager.GetString(Name, CultureInfo.CurrentUICulture) ?? Name)?.ToLower();
      return result;
    }
  }
  public TNS TypeNameSelector { get; private set; }

  public TKS TypeKindSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

  public int Count => Items.Count;

  public virtual IList Items { get; } = new ObservableList<TypeInfoViewModel>();

  public IEnumerable<TypeInfoViewModel> Types => Items.Cast<TypeInfoViewModel>();

  public TypeInfoFilter? Filter { get; private set; }

  public TypeListViewModel? Source { get; private set; }


  public bool ShowFullTypeName
  {
    get => TypeNameSelector.Namespace;
    set
    {
      if (TypeNameSelector.Namespace != value)
      {
        TypeNameSelector.Namespace = value;
        foreach (var typeInfo in Types)
          typeInfo.ShowFullTypeName = value;
        NotifyPropertyChanged(nameof(ShowFullTypeName));
        RefreshItemsAsync();
      }
    }
  }

  public bool IsTargetNameVisible
  {
    get => _isTargetNameVisible ?? Phase.IsTargetNameVisible;
    set => _isTargetNameVisible = value;
  }
  private bool? _isTargetNameVisible;

  public bool IsInvalidMarkVisible
  {
    get => _isInvalidMarkVisible ?? Phase.IsInvalidMarkVisible;
    set => _isInvalidMarkVisible = value;
  }
  private bool? _isInvalidMarkVisible;

  public bool CanShowErrorDetails
  {
    get => _canShowErrorDetails ?? Phase.CanShowErrorDetails;
    set => _canShowErrorDetails = value;
  }
  private bool? _canShowErrorDetails;

  #region ShowDetailsCommand

  public Command ShowDetailsCommand { get; private set; }

  public async void FillItemsAsync()
  {
    await Task.Run(() => FillItems());
  }

  public void FillItems()
  {
    if (Source != null)
      FilterItems(Source.Types);
    else
      CreateItems(GetModelTypes());
    foreach (var vm in Types)
      vm.FillDetailsAsync();
  }

  private IEnumerable<TypeInfo> GetModelTypes()
  {
    var types = Namespace?.Model.Types.ToList()
      ?? ModelGen.TypeManager.AllTypes.ToList();
    if (Filter != null)
        types = types.Where(item => Filter.Predicate(item)).ToList();
    return types;
  }

  private void CreateItems(IEnumerable<TypeInfo> types)
  {
    Items.Clear();
    if (TypeKindSelector != TKS.Any)
      AddRange(types.Where(item => item.IsTypeKindSelected(TypeKindSelector))
      .Select(item => CreateItemViewModel(item, Phase)));
    else
      AddRange(types.Select(item => CreateItemViewModel(item, Phase)));
  }

  private void FilterItems(IEnumerable<TypeInfoViewModel> types)
  {
    Items.Clear();
    if (TypeKindSelector != TKS.Any)
      AddRange(types.Where(item => item.IsTypeKindSelected(TypeKindSelector)));
    else
      AddRange(types);
  }

  public async void RefreshItemsAsync()
  {
    await Task.Run(() => RefreshItems());
  }

  public void RefreshItems()
  {
    if (Source != null)
      RefreshFilteredItems(Source.Types);
    else
      RefreshCreatedItems(GetModelTypes());
    foreach (var vm in Types)
      vm.RefreshDetailsAsync();
  }

  private void RefreshCreatedItems(IEnumerable<TypeInfo> types)
  {
    var newTypes = new List<TypeInfo>();
    foreach (var typeInfo in types)
      if (!Types.Any(vm => vm.Model == typeInfo))
        newTypes.Add(typeInfo);

    if (TypeKindSelector != TKS.Any)
      AddRange(newTypes.Where(item => item.IsTypeKindSelected(TypeKindSelector))
      .Select(item => CreateItemViewModel(item, Phase)));
    else
      AddRange(newTypes.Select(item => CreateItemViewModel(item, Phase)));
  }

  private void RefreshFilteredItems(IEnumerable<TypeInfoViewModel> types)
  {
    var newTypes = new List<TypeInfoViewModel>();
    foreach (var typeInfo in types)
      if (!Types.Any(vm => vm == typeInfo))
        newTypes.Add(typeInfo);

    if (TypeKindSelector != TKS.Any)
      AddRange(newTypes.Where(item => item.IsTypeKindSelected(TypeKindSelector)));
    else
      AddRange(newTypes);
  }

  protected virtual TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseViewModel phase)
  {
    return TypeInfoViewModel.Create(phase, item, TypeNameSelector);
  }


  protected virtual bool ShowDetailsCanExecute()
  {
    return Items.Count > 0;
  }

  protected virtual void ShowDetailsExecute()
  {
    WindowsManager.ShowWindow<TypeListWindow>(this);
  }
  #endregion

  #region RefreshResultsCommand
  /// <summary>
  /// Command to show phase result window.
  /// </summary>
  public Command RefreshResultsCommand
  {
    get { return _RefreshResultsCommand; }
    set
    {
      if (_RefreshResultsCommand != value)
      {
        _RefreshResultsCommand = value;
        NotifyPropertyChanged(nameof(_RefreshResultsCommand));
      }
    }
  }
  private Command _RefreshResultsCommand = null!;

  protected void RefreshResultsExecute()
  {
    RefreshItemsAsync();
  }

  protected virtual bool RefreshResultsCanExecute()
  {
    return true;//Percentage == 100;
  }
  #endregion

  public bool AreAllTypesValid => Types.Any(item => !item.IsValid);


}
