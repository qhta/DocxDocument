namespace ModelGenApp.ViewModels;
public class TypeListViewModel : ViewModel
{
  public TypeListViewModel(PhaseViewModel phase, NamespaceViewModel? nspace, string name, NKS typeNameSelector, TKS typeKindSelector)
  {
    Namespace = nspace;
    Name = name;
    if (Items is INotifyCollectionChanged observableCollection)
      observableCollection.CollectionChanged += ObservableCollection_CollectionChanged;
    TypeNameSelector = typeNameSelector;
    TypeKindSelector = typeKindSelector;
    Phase = phase;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  private void ObservableCollection_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
  {
    NotifyPropertyChanged(nameof(Count));
  }

  public TypeListViewModel(PhaseViewModel phase, NamespaceViewModel? nspace, string name, NKS typeNameSelector, IEnumerable<TypeInfoViewModel> list)
  {
    Namespace = nspace;
    Name = name;
    TypeNameSelector = typeNameSelector;
    Items.AddRange(list);
    Phase = phase;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  public NamespaceViewModel? Namespace { get; private set; }

  public string Name { get; private set; }

  public string Caption
  {
    get
    {
      if (Namespace != null)
        return Namespace.Caption + ": " + this.Name?.ToLower();
      return this.Name;
    }
  }
  public NKS TypeNameSelector { get; private set; }

  public TKS TypeKindSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

  public int Count => Items.Count;

  public virtual IList Items { get; } = new DispatchedCollection<TypeInfoViewModel>();

  public IEnumerable<TypeInfoViewModel> Types => Items.Cast<TypeInfoViewModel>();

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

  public void CreateItems(IEnumerable<TypeInfo> types)
  {
    Items.Clear();
    if (TypeKindSelector != TKS.Any)
      Items.AddRange(types.Where(item => item.IsTypeKindSelected(TypeKindSelector))
      .Select(item => CreateItemViewModel(item, Phase)));
    else
      Items.AddRange(types.Select(item => CreateItemViewModel(item, Phase)));
  }

  public void FilterItems(IEnumerable<TypeInfoViewModel> types)
  {
    Items.Clear();
    if (TypeKindSelector != TKS.Any)
      Items.AddRange(types.Where(item => item.IsTypeKindSelected(TypeKindSelector)));
    else
      Items.AddRange(types);
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
    Helpers.WindowsManager.ShowWindow<TypeListWindow>(this);
  }
  #endregion

}
