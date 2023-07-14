namespace ModelGenApp.ViewModels;
public class TypeListViewModel: ViewModel
{
  public TypeListViewModel(NamespaceViewModel owner, string name, NTS nameTypeSelector, TKS typeKindSelector)
  {
    Owner = owner;
    Name = name;
    NameTypeSelector = nameTypeSelector;
    TypeKindSelector = typeKindSelector;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  public NamespaceViewModel Owner { get; private set; }

  public string Name { get; private set; }

  public string Caption => Owner.Caption +": "+this.Name?.ToLower();

  public NTS NameTypeSelector { get; private set; }

  public TKS TypeKindSelector { get; private set; }

  public virtual IList Items { get;} = new DispatchedCollection<TypeInfoViewModel>();

  public bool IsAcceptanceVisible { get; set; } = true;

  public bool IsValidityVisible { get; set; } = false;

  public bool IsTargetNameVisible => Owner.Phase.IsTargetNameVisible;

  #region ShowDetailsCommand
  public Command ShowDetailsCommand { get; private set; }

  public void LoadTypes(IEnumerable<TypeInfo> nsTypes)
  {
    if (TypeKindSelector!=TKS.Any)
      Items.AddRange(nsTypes.Where(item=>item.IsTypeKindSelected(TypeKindSelector))
      .Select(item => CreateItemViewModel(item)));
    else
      Items.AddRange(nsTypes.Select(item => CreateItemViewModel(item)));
  }

  protected virtual TypeInfoViewModel CreateItemViewModel(TypeInfo item)
  {
    return new TypeInfoViewModel(item, NameTypeSelector.HasFlag(NTS.Origin));
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
