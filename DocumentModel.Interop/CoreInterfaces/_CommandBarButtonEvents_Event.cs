using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[ComVisible(false)]
[ComEventInterface(typeof(_CommandBarButtonEvents), typeof(_CommandBarButtonEvents_EventProvider))]
public interface _CommandBarButtonEvents_Event
{
  event _CommandBarButtonEvents_ClickEventHandler Click;
}