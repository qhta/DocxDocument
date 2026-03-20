
namespace DocumentModel.Interop.Core;

/// <summary>
/// Events interface for `CustomXMLPart` object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents?view=office-pia
/// </remarks>
public partial interface ICustomXMLPartEvents
{
  /// <summary>
  /// Raised after a custom XML node is inserted.
  /// </summary>
  /// <param name="NewNode">The `NewNode` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterinsert?view=office-pia
  /// </remarks>
  public void NodeAfterInsert(CustomXMLNode NewNode, bool InUndoRedo);
  /// <summary>
  /// Raised after a custom XML node is deleted.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="OldParentNode">The `OldParentNode` parameter.</param>
  /// <param name="OldNextSibling">The `OldNextSibling` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterdelete?view=office-pia
  /// </remarks>
  public void NodeAfterDelete
    (CustomXMLNode OldNode, CustomXMLNode OldParentNode, CustomXMLNode OldNextSibling, bool InUndoRedo);
  /// <summary>
  /// Raised after a custom XML node is replaced.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="NewNode">The `NewNode` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterreplace?view=office-pia
  /// </remarks>
  public void NodeAfterReplace(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);
}
