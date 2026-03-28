using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComVisible(false)]
[ComEventInterface(typeof(OLEObjectEvents), typeof(OLEObjectEvents_EventProvider))]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public interface OLEObjectEvents_Event
{
  event OLEObjectEvents_GotFocusEventHandler GotFocus;
  event OLEObjectEvents_LostFocusEventHandler LostFocus;
}