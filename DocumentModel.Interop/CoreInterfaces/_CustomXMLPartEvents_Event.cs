using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComVisible(false)]
[ComEventInterface(typeof(_CustomXMLPartEvents), typeof(_CustomXMLPartEvents_EventProvider))]
[TypeLibType(16)]
public interface _CustomXMLPartEvents_Event
{
  event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert;
  event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete;
  event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace;
}