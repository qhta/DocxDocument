using ModelGenApp.Views;

namespace ModelGenApp.ViewModels;
public class TypeListViewModel: DispatchedCollection<TypeInfoViewModel>
{
  public TypeListViewModel(NamespaceViewModel owner, string name)
  {
    Owner = owner;
    Name = name;
    ShowDetailsCommand = new RelayCommand(ShowDetailsExecute, ShowDetailsCanExecute) { Name = "ShowDetailsCommand" };
  }

  internal NamespaceViewModel Owner { get; private set; }

  public string Caption => Owner.Caption +": "+this.Name?.ToLower();

  #region ShowDetailsCommand
  public Command ShowDetailsCommand
  {
    get { return _ShowDetailsCommand; }
    set
    {
      if (_ShowDetailsCommand != value)
      {
        _ShowDetailsCommand = value;
        NotifyPropertyChanged(nameof(_ShowDetailsCommand));
      }
    }
  }
  private Command _ShowDetailsCommand = null!;

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
      window = new TypeListWindow();
      window.DataContext = this;
      window.Show();
    }
  }
  #endregion


}
