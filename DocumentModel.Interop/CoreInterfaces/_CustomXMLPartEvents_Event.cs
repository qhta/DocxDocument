
namespace DocumentModel.Interop.Core;

public delegate void _CustomXMLPartEvents_NodeAfterInsertEventHandler(CustomXMLNode NewNode, bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterDeleteEventHandler(
  CustomXMLNode OldNode,
  CustomXMLNode OldParentNode,
  CustomXMLNode OldNextSibling,
  bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterReplaceEventHandler(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);

public interface _CustomXMLPartEvents_Event
{
  event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert;
  event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete;
  event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace;
}