namespace ModelGenApp.ViewModels;
public class TypeListViewModel: ViewModel
{
  public TypeListViewModel(NamespaceViewModel owner, string name)
  {
    Owner = owner;
    Name = name;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  public NamespaceViewModel Owner { get; private set; }

  public string Name { get; private set; }

  public string Caption => Owner.Caption +": "+this.Name?.ToLower();

  public virtual IList Items { get;} = new DispatchedCollection<TypeInfoViewModel>();

  public int Count => Items.Count;

  #region ShowDetailsCommand
  public Command ShowDetailsCommand { get; private set; }

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
      window.DataContext = Items;
      window.Show();
    }
  }
  #endregion


}
