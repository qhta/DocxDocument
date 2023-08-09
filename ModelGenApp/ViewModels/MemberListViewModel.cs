namespace ModelGenApp.ViewModels;
public class MemberListViewModel<T> : ObservableList<T> where T : ViewModel, IAcceptable
{
  public MemberListViewModel(TypeInfoViewModel owner, string name)
  {
    Owner = owner;
    Name = name;
    CollectionChanged += MemberListViewModel_CollectionChanged;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  private void MemberListViewModel_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
  {
    NotifyPropertyChanged(nameof(Items));
  }

  public TypeInfoViewModel Owner { get; private set; }

  public string Name { get; private set; }

  public string Caption => Owner.Caption + "." + this.Name?.ToLower();

  public string Label => this.Name + ":";

  public bool Visible => true;

  public IEnumerable<T> Items
  {
    get
    {
      if (ShowAcceptedOnly)
        return this.Where(item=>item.IsAccepted);
      return this;
    }
  }

  public bool ShowAcceptedOnly
  {
    get => _showAcceptedOnly;
    set
    {
      if (value != _showAcceptedOnly)
      {
        _showAcceptedOnly = value;
        NotifyPropertyChanged(nameof(ShowAcceptedOnly));
        NotifyPropertyChanged(nameof(Items));
      }
    }
  }
  private static bool _showAcceptedOnly = true;

  public bool ShowAcceptedOnlyVisible { get; protected set; }

  public bool ShowDeclaringType
  {
    get => _showDeclaringType;
    set
    {
      if (value != _showDeclaringType)
      {
        _showDeclaringType = value;
        NotifyPropertyChanged(nameof(ShowDeclaringType));
        NotifyPropertyChanged(nameof(Items));
      }
    }
  }
  private static bool _showDeclaringType = true;

  public bool ShowDeclaringTypeVisible { get; protected set; }

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
