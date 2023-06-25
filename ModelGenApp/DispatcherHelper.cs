namespace ModelGenApp;

public static class DispatcherHelper
{
  public static void Execute(Action action)
  {
    if (Application.Current is null || Application.Current.Dispatcher is null)
      return;

    // Marshall to Main Thread
    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, action);
  }
}
