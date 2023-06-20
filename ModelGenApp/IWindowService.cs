namespace ModelGenApp;
public interface IWindowService
{
  Window? ShowWindow(ObservableObject viewModel, Window? ownerWindow);
}

public class WindowService : IWindowService
{
  //public readonly Window Owner;

  public WindowService(/*Window owner*/)
  {
    //this.Owner = owner;
  }

  public Window? ShowWindow(ObservableObject viewModel, Window? ownerWindow)
  {
    var dataTemplate = (DataTemplate)Application.Current.FindResource(viewModel.GetType());
    var window = dataTemplate.LoadContent() as Window;
    if (window != null)
    {
      window.Owner = ownerWindow;
      window.DataContext = viewModel;
      window.Show();
    }
    return window;
  }
}
