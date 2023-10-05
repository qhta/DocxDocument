namespace ModelGenApp.ViewModels;
public class TypeListViewModel<T> : ViewModel where T : TypeInfoViewModel
{
  public TypeListViewModel(PhaseResultsViewModel phase, NamespaceViewModel? nspace, string name,
    TNS typeNameSelector, TKS typeKindSelector, TypeInfoViewModelFilter? filter, TypeListViewModel<TypeInfoViewModel>? source)
  {
    //Debug.WriteLine($"TypeListViewModel.Ctor({name}, \"{nspace?.Name}\")");
    Namespace = nspace;
    Name = name;
    Items.CollectionChanged += Items_CollectionChanged;
    VisibleItems = new FilteredCollection<T>(Items, filter);
    VisibleItems.CollectionChanged += VisibleItems_CollectionChanged;
    //TypeNameSelector = typeNameSelector;
    TypeKindSelector = typeKindSelector;
    Phase = phase;
    Source = source;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
    RefreshResultsCommand = new RelayCommand(RefreshResultsExecute, RefreshResultsCanExecute) { Name = "RefreshResultsCommand" };
    BusyMonitor.Instance.PropertyChanged += BusyMonitor_PropertyChanged;
    phase.PropertyChanged += Phase_PropertyChanged;
    if (phase.PhaseNum > PPS.ScanSource)
      ShowAcceptedOnly = true;
  }



  public bool IsBusy => BusyMonitor.Instance.IsBusy;

  private void BusyMonitor_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(BusyMonitor.IsBusy))
      NotifyPropertyChanged(nameof(IsBusy));
  }


  private void Phase_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (sender == Phase && args.PropertyName == nameof(PhaseResultsViewModel.ShowTargetsOnly))
    {
      NotifyPropertyChanged(nameof(ShowTargetsOnly));
      if (ShowTargetsOnly)
      {
        ShowAcceptedOnly = true;
        ShowAcceptedOnlyEnabled = false;
        ApplyAcceptedOnlyFilterAsync(true);
      }
      else
        ShowAcceptedOnlyEnabled = true;

    }
  }

  public TypeInfoViewModelFilter? Filter
  {
    get { return _Filter; }
    set
    {
      if (_Filter != value)
      {
        _Filter = value;
        NotifyPropertyChanged(nameof(Filter));
        ApplyFilter();
      }
    }
  }
  private TypeInfoViewModelFilter? _Filter;

  public void ApplyFilter()
  {
    if (VisibleItems != null)
    {
      VisibleItems.Filter = Filter;
      RefreshItems();
    }
  }


  private void VisibleItems_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    NotifyPropertyChanged(nameof(Count));
    ShowDetailsCommand?.NotifyCanExecuteChanged();
  }

  private void Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    NotifyPropertyChanged(nameof(Count));
    ShowDetailsCommand?.NotifyCanExecuteChanged();
  }

  protected virtual void AddRange(IEnumerable<TypeInfoViewModel> list)
  {
    (Items).AddRange(list.Cast<T>());
  }
  public NamespaceViewModel? Namespace { get; private set; }

  public string Name { get; private set; }

  public string Caption
  {
    get
    {
      string? result = null;
      if (Namespace != null)
        result = Namespace.Caption;
      result += " | " + (CommonStrings.ResourceManager.GetString(Name, CultureInfo.CurrentUICulture) ?? Name?.DeCamelCase());
      return result;
    }
  }

  public NTS NamespacesSelector => Phase.NamespacesSelector;

  public TNS TypeNameSelector => Phase.TypeNameSelector;

  public TKS TypeKindSelector { get; private set; }

  public bool ShowAcceptance => !ShowAcceptedOnly;

  public bool ShowTargetName => Phase.PhaseNum >= PPS.Rename && !Phase.ShowTargetsOnly;

  public bool ShowConversionTarget => Phase.PhaseNum >= PPS.ConvertTypes && !Phase.ShowTargetsOnly;

  public bool ShowTargetType => Phase.PhaseNum >= PPS.ConvertTypes;


  public PhaseResultsViewModel Phase { get; private set; }

  public int Count => VisibleItems.Count;

  public virtual ObservableList<T> Items { get; } = new ObservableList<T>();

  public IEnumerable<TypeInfoViewModel> Types => Items;

  public FilteredCollection<T> VisibleItems { get; private set; } = null!;

  public TypeListViewModel<TypeInfoViewModel>? Source { get; private set; }


  public bool ShowNamespaces => Namespace == null;

  public bool ShowTargetsOnlyEnabled => Phase.ShowTargetsOnlyEnabled;

  public bool ShowTargetsOnly { get => Phase.ShowTargetsOnly; set => Phase.ShowTargetsOnly = value; }

  public bool ShowAcceptedOnly
  {
    get => _ShowAcceptedOnly;
    set
    {
      if (value != _ShowAcceptedOnly)
      {
        _ShowAcceptedOnly = value;
        NotifyPropertyChanged(nameof(ShowAcceptedOnly));
        NotifyPropertyChanged(nameof(ShowAcceptance));
        ApplyAcceptedOnlyFilterAsync(value);
      }
    }
  }
  private bool _ShowAcceptedOnly = false;


  public bool ShowAcceptedOnlyEnabled
  {
    get { return _ShowAcceptedOnlyEnabled; }
    set
    {
      if (_ShowAcceptedOnlyEnabled != value)
      {
        _ShowAcceptedOnlyEnabled = value;
        NotifyPropertyChanged(nameof(ShowAcceptedOnlyEnabled));
      }
    }
  }
  private bool _ShowAcceptedOnlyEnabled = true;

  protected async void ApplyAcceptedOnlyFilterAsync(bool value)
  {
    await Task.Factory.StartNew(() => ApplyAcceptedOnlyFilter(value));
  }

  protected void ApplyAcceptedOnlyFilter(bool value)
  {
    if (value)
    {
      VisibleItems.Filter = new TypeInfoViewModelFilter(TypeInfoKind.AcceptedTypes, Phase.PhaseNum);
    }
    else
      VisibleItems.Filter = null;
  }

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


  public async void FillItemsAsync()
  {
    await Task.Factory.StartNew(() => FillItems());
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
    await Task.Factory.StartNew(() => RefreshItems());
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

  protected virtual TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseResultsViewModel phase)
  {
    return TypeInfoViewModel.Create(phase, item, TypeNameSelector);
  }

  #region ShowDetailsCommand

  public Command ShowDetailsCommand { get; private set; }

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

  public bool HasAnyInvalidTypes => VisibleItems.Any(item => item.Model.IsInvalid(this.Phase.PhaseNum));


}
