using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComEventInterface(typeof(RefreshEvents), typeof(RefreshEvents_EventProvider))]
[TypeLibType(TypeLibTypeFlags.FHidden)]
[ComVisible(false)]
public interface RefreshEvents_Event
{
  event RefreshEvents_BeforeRefreshEventHandler BeforeRefresh;
  event RefreshEvents_AfterRefreshEventHandler AfterRefresh;
}