
namespace DocumentModel.Interop.Core;

public interface _CustomXMLPartEvents
{
  public void NodeAfterInsert(CustomXMLNode NewNode, bool InUndoRedo);

  public void NodeAfterDelete
    (CustomXMLNode OldNode, CustomXMLNode OldParentNode, CustomXMLNode OldNextSibling, bool InUndoRedo);

  public void NodeAfterReplace(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);
}
