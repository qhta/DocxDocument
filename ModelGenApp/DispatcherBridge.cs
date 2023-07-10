namespace ModelGenApp;

public class DispatcherBridge : IDispatcherBridge
{
  public void Invoke(Action action)
  {
    DispatcherHelper.Invoke(action);
  }

  public void Invoke(Action action, object[] args)
  {
    DispatcherHelper.Invoke(action, args);
  }
}
