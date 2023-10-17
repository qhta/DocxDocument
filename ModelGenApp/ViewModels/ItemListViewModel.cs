namespace ModelGenApp.ViewModels;
public abstract class ItemListViewModel<T> : ViewModel, IEnumerable<T> where T : ViewModel, IAcceptable
{
  public ItemListViewModel(PhaseResultsViewModel phase, TypeInfoViewModel? ownerType, string name, MemberInfoViewModelFilter? filter = null)
  {
    Phase = phase;
    OwnerType = ownerType;
    Name = name;
    Items = new ObservableList<T>();
    Items.CollectionChanged += Item_CollectionChanged;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
    VisibleItems = new FilteredCollection<T>(Items, filter);
    VisibleItems.CollectionChanged += VisibleItems_CollectionChanged;
    ApplyAcceptedOnlyFilter(ShowAcceptedOnly);

  }

  public bool IsBusy => BusyMonitor.Instance.IsBusy;

  private void BusyMonitor_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName==nameof(BusyMonitor.IsBusy))
      NotifyPropertyChanged(nameof(IsBusy));
  }

  private void Item_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    NotifyPropertyChanged(nameof(VisibleItems));
    NotifyPropertyChanged(nameof(Count));
  }

  private void VisibleItems_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    NotifyPropertyChanged(nameof(Count));
  }

  public PhaseResultsViewModel Phase { get; private set; }

  public TypeInfoViewModel? OwnerType { get; private set; }

  public string Name { get; private set; }

  public string Caption
  {
    get
    {
      var result = OwnerType?.Caption;
      if (result != null)
        result += " | ";
      result += this.Name;
      return result;
    }
  }

  public string Label => this.Name + ":";

  public bool Visible => true;

  public ObservableList<T> Items { get; private set; }

  public FilteredCollection<T> VisibleItems { get; private set; } = null!;

  public bool ShowAcceptedOnly
  {
    get => _ShowAcceptedOnly;
    set
    {
      if (value != _ShowAcceptedOnly)
      {
        _ShowAcceptedOnly = value;
        NotifyPropertyChanged(nameof(ShowAcceptedOnly));
        ApplyAcceptedOnlyFilter(value);
      }
    }
  }
  /// <summary>
  /// As this field is static, all member lists have the same, common default value.
  /// </summary>
  private static bool _ShowAcceptedOnly = true;

  protected abstract void ApplyAcceptedOnlyFilter(bool value);

  public bool ShowDeclaringType
  {
    get => _showDeclaringType;
    set
    {
      if (value != _showDeclaringType)
      {
        _showDeclaringType = value;
        NotifyPropertyChanged(nameof(ShowDeclaringType));
      }
    }
  }
  /// <summary>
  /// As this field is static, all member lists have the same, common default value.
  /// </summary>
  private static bool _showDeclaringType = true;

  public bool ShowDisplayOptions { get; protected set; }

  #region ShowDetailsCommand
  public Command ShowDetailsCommand { get; private set; }

  protected virtual bool ShowDetailsCanExecute()
  {

    return OwnerType!=null && Items.Count > 0;
  }


  protected virtual void ShowDetailsExecute()
  {
    if (OwnerType != null)
      WindowsManager.ShowWindow<TypeInfoWindow>(OwnerType);
  }
  #endregion

  #region Filter
  public MemberInfoViewModelFilter? Filter
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
  private MemberInfoViewModelFilter? _Filter;

  public void ApplyFilter()
  {
    if (VisibleItems != null)
    {
      VisibleItems.Filter = Filter;
    }
  }
  #endregion

  #region Collection methods

  public void Add(T item)
  {
    ((ICollection<T>)Items).Add(item);
  }

  public void Clear()
  {
    ((ICollection<T>)Items).Clear();
  }

  public bool Contains(T item)
  {
    return ((ICollection<T>)Items).Contains(item);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    ((ICollection<T>)Items).CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    return ((ICollection<T>)Items).Remove(item);
  }

  public int Count => VisibleItems.Count;

  public bool IsReadOnly => ((ICollection<T>)Items).IsReadOnly;

  public IEnumerator<T> GetEnumerator()
  {
    return ((IEnumerable<T>)Items).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Items).GetEnumerator();
  }
  #endregion

}
