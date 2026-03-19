using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[ComEventInterface(typeof(_CommandBarComboBoxEvents), typeof(_CommandBarComboBoxEvents_EventProvider))]
[ComVisible(false)]
public interface _CommandBarComboBoxEvents_Event
{
  event _CommandBarComboBoxEvents_ChangeEventHandler Change;
}