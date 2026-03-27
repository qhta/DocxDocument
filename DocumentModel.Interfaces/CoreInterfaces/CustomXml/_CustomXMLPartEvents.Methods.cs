
namespace DocumentModel.CustomXml;

/// <summary>
/// Events interface for CustomXMLPart object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents?view=office-pia"/>
public partial interface _CustomXMLPartEvents
{
  /// <summary>
  /// Occurs after a node is inserted in a CustomXMLPart object.
  /// </summary>
  /// <param name="NewNode">The `NewNode` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents.nodeafterinsert?view=office-pia"/>
  public void NodeAfterInsert(CustomXMLNode NewNode, bool InUndoRedo);
  /// <summary>
  /// Occurs after a node is deleted in a CustomXMLPart object.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="OldParentNode">The `OldParentNode` parameter.</param>
  /// <param name="OldNextSibling">The `OldNextSibling` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents.nodeafterdelete?view=office-pia"/>
  public void NodeAfterDelete
    (CustomXMLNode OldNode, CustomXMLNode OldParentNode, CustomXMLNode OldNextSibling, bool InUndoRedo);
  /// <summary>
  /// Occurs just after a node is replaced in a CustomXMLPart object.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="NewNode">The `NewNode` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents.nodeafterreplace?view=office-pia"/>
  public void NodeAfterReplace(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);
}

