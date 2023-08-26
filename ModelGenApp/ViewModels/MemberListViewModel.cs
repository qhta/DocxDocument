namespace ModelGenApp.ViewModels;
public abstract class MemberListViewModel<T> : ObservableList<T> where T : ViewModel, IAcceptable
{
  public MemberListViewModel(TypeInfoViewModel owner, string name)
  {
    Owner = owner;
    Name = name;
    CollectionChanged += MemberListViewModel_CollectionChanged;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
    VisibleItems = new FilteredCollection<T>(this);
    ApplyAcceptedOnlyFilter(ShowAcceptedOnly);
  }

  private void MemberListViewModel_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    NotifyPropertyChanged(nameof(VisibleItems));
  }

  public TypeInfoViewModel Owner { get; private set; }

  public string Name { get; private set; }

  public string Caption => Owner.Caption + " | " + this.Name;

  public string Label => this.Name + ":";

  public bool Visible => true;

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
    return Count > 0;
  }


  protected virtual void ShowDetailsExecute()
  {
    WindowsManager.ShowWindow<TypeInfoWindow>(Owner);
  }
  #endregion

}
