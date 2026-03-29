
namespace DocumentModel.CustomXml;

/// <summary>
/// Events interface for `CustomXMLPart` object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents?view=office-pia"/>
public partial interface CustomXMLPartEvents: InteropObject
{
  /// <summary>
  /// Raised after a custom XML node is inserted.
  /// </summary>
  /// <param name="NewNode">The `NewNode` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterinsert?view=office-pia"/>
  public void NodeAfterInsert(CustomXMLNode NewNode, bool InUndoRedo);
  /// <summary>
  /// Raised after a custom XML node is deleted.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="OldParentNode">The `OldParentNode` parameter.</param>
  /// <param name="OldNextSibling">The `OldNextSibling` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterdelete?view=office-pia"/>
  public void NodeAfterDelete
    (CustomXMLNode OldNode, CustomXMLNode OldParentNode, CustomXMLNode OldNextSibling, bool InUndoRedo);
  /// <summary>
  /// Raised after a custom XML node is replaced.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="NewNode">The `NewNode` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterreplace?view=office-pia"/>
  public void NodeAfterReplace(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);
}

