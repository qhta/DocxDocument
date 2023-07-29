namespace ModelGenApp.ViewModels;
public class TypeListViewModel: ViewModel
{
  public TypeListViewModel(PhaseViewModel phase, NamespaceViewModel nspace, string name, TNS typeNameSelector, TKS typeKindSelector)
  {
    Namespace = nspace;
    Name = name;
    TypeNameSelector = typeNameSelector;
    TypeKindSelector = typeKindSelector;
    Phase = phase;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  public TypeListViewModel(PhaseViewModel phase, NamespaceViewModel nspace, string name, TNS typeNameSelector, IEnumerable<TypeInfoViewModel> list)
  {
    Namespace = nspace;
    Name = name;
    TypeNameSelector = typeNameSelector;
    Items.AddRange(list);
    Phase = phase;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  public NamespaceViewModel Namespace { get; private set; }

  public string Name { get; private set; }

  public string Caption => Namespace.Caption +": "+this.Name?.ToLower();

  public TNS TypeNameSelector { get; private set; }

  public TKS TypeKindSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

  public virtual IList Items { get;} = new DispatchedCollection<TypeInfoViewModel>();

  public bool IsTargetNameVisible => Namespace.Phase.IsTargetNameVisible;
  public bool IsInvalidMarkVisible => Namespace.Phase.IsInvalidMarkVisible;

  #region ShowDetailsCommand
  public Command ShowDetailsCommand { get; private set; }

  public void LoadTypes(IEnumerable<TypeInfo> nsTypes)
  {
    if (TypeKindSelector!=TKS.Any)
      Items.AddRange(nsTypes.Where(item=>item.IsTypeKindSelected(TypeKindSelector))
      .Select(item => CreateItemViewModel(item, Phase)));
    else
      Items.AddRange(nsTypes.Select(item => CreateItemViewModel(item, Phase)));
  }

  protected virtual TypeInfoViewModel CreateItemViewModel(TypeInfo item, PhaseViewModel phase)
  {
    return new TypeInfoViewModel(phase, item, TypeNameSelector);
  }


  protected virtual bool ShowDetailsCanExecute()
  {
    return Items.Count>0;
  }

  Window? window;
  protected virtual void ShowDetailsExecute()
  {
    if (window != null && window.IsVisible)
    {
      window.Topmost=true;
      window.Focus();
    }
    else
    {
      window = new TypeListWindow();
      window.DataContext = this;
      window.Show();
    }
  }
  #endregion

}
