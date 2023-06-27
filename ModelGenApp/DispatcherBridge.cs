using Qhta.DispatchedObjects;

namespace ModelGenApp;

public class DispatcherBridge: IDispatcherBridge
{
  public void Invoke(Action action)
  {
    DispatcherHelper.Execute(action);
  }
}
