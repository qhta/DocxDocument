namespace ModelGenApp;

public static class DispatcherHelper
{
  public static void Invoke(Action action)
  {
    if (Application.Current is null || Application.Current.Dispatcher is null)
      return;

    // Marshall to Main Thread
    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, action);
  }

  public static void Invoke(Action action, object[] args)
  {
    if (Application.Current is null || Application.Current.Dispatcher is null)
      return;

    // Marshall to Main Thread
    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, action, args);
  }
}
