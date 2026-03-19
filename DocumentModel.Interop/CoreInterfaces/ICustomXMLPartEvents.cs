
namespace DocumentModel.Interop.Core;

public interface ICustomXMLPartEvents
{
  void NodeAfterInsert(CustomXMLNode NewNode, bool InUndoRedo);

  void NodeAfterDelete
    (CustomXMLNode OldNode, CustomXMLNode OldParentNode, CustomXMLNode OldNextSibling, bool InUndoRedo);

  void NodeAfterReplace(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);
}