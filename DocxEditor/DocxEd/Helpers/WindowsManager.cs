namespace DocxEd.Helpers;
public static class WindowsManager
{
  private static Dictionary<object, Window> KnownWindows = new Dictionary<object, Window>();

  public static void ShowWindow<WindowType>(Object dataContext) where WindowType : Window, new()
  {
    //if (typeof(WindowType)==typeof(TypeListWindow))
    //  Debug.WriteLine($"Open {typeof(WindowType)}");
    if (KnownWindows.TryGetValue(dataContext, out var knownWindow))
    {
      knownWindow.Activate();
    }
    else
    {
      var window = new WindowType();
      window.DataContext = dataContext;
      window.Closed += Window_Closed;
      KnownWindows.Add(dataContext, window);
      window.Show();
      window.Activate();
    }
  }

  private static void Window_Closed(object? sender, EventArgs e)
  {
    var window = sender as Window;
    if (window?.DataContext != null)
    {
      KnownWindows.Remove(window.DataContext);
    }
  }
}
