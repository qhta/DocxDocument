namespace ModelGenApp.ViewModels;
public class PropListViewModel: DispatchedCollection<PropInfoViewModel>
{
  public PropListViewModel(ClassInfoViewModel owner, string name)
  {
    Owner = owner;
    Name = name;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  public ClassInfoViewModel Owner { get; private set; }

  public string Name { get; private set; }

  public string Caption => Owner.Caption +": "+this.Name?.ToLower();

  public string Label => this.Name+":";

  public bool Visible => true;

  #region ShowDetailsCommand
  public Command ShowDetailsCommand { get; private set; }
  protected virtual bool ShowDetailsCanExecute()
  {
    return Count>0;
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
      window = new TypeInfoWindow();
      window.DataContext = Owner;
      window.Show();
    }
  }
  #endregion

}
