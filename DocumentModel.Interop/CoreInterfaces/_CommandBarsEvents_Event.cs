
namespace DocumentModel.Interop.Core;

public delegate void _CommandBarsEvents_OnUpdateEventHandler();

public interface _CommandBarsEvents_Event
{
  public event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;
}
