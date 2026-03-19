using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[ComEventInterface(typeof(_CustomTaskPaneEvents), typeof(_CustomTaskPaneEvents_EventProvider))]
[ComVisible(false)]
public interface _CustomTaskPaneEvents_Event
{
  event _CustomTaskPaneEvents_VisibleStateChangeEventHandler VisibleStateChange;
  event _CustomTaskPaneEvents_DockPositionStateChangeEventHandler DockPositionStateChange;
}