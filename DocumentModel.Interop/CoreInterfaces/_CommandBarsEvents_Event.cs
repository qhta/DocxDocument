using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComVisible(false)]
[TypeLibType(16)]
[ComEventInterface(typeof(_CommandBarsEvents), typeof(_CommandBarsEvents_EventProvider))]
public interface _CommandBarsEvents_Event
{
  event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;
}