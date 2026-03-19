using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
[ComVisible(false)]
[ComEventInterface(typeof(_CustomXMLPartsEvents), typeof(_CustomXMLPartsEvents_EventProvider))]
public interface _CustomXMLPartsEvents_Event
{
  event _CustomXMLPartsEvents_PartAfterAddEventHandler PartAfterAdd;
  event _CustomXMLPartsEvents_PartBeforeDeleteEventHandler PartBeforeDelete;
  event _CustomXMLPartsEvents_PartAfterLoadEventHandler PartAfterLoad;
}