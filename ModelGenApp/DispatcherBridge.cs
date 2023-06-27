using Qhta.DispatchedObjects;

namespace ModelGenApp;

public class DispatcherBridge: IDispatcherBridge
{

  public Dispatcher GetDispatcher()
  {
    return Application.Current.Dispatcher;
  }
}
