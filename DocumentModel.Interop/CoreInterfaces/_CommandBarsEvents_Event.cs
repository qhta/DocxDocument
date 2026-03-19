
namespace DocumentModel.Interop.Core;

public delegate void _CommandBarsEvents_OnUpdateEventHandler();

public interface _CommandBarsEvents_Event
{
  event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;
}