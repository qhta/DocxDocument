
namespace DocumentModel.Interop.Core;

/// <summary>
/// Events interface for `CustomXMLPart` object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents?view=office-pia"/>
public interface ICustomXMLPartEvents
{


  #region methods

/// <summary>
  /// Raised after a custom XML node is inserted.
  /// </summary>
  /// <param name="newNode">The `NewNode` parameter.</param>
  /// <param name="inUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterinsert?view=office-pia"/>
  public void NodeAfterInsert(ICustomXMLNode newNode, bool inUndoRedo);
  /// <summary>
  /// Raised after a custom XML node is deleted.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="OldParentNode">The `OldParentNode` parameter.</param>
  /// <param name="OldNextSibling">The `OldNextSibling` parameter.</param>
  /// <param name="InUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterdelete?view=office-pia"/>
  public void NodeAfterDelete
    (ICustomXMLNode OldNode, ICustomXMLNode OldParentNode, ICustomXMLNode OldNextSibling, bool InUndoRedo);
  /// <summary>
  /// Raised after a custom XML node is replaced.
  /// </summary>
  /// <param name="oldNode">The `OldNode` parameter.</param>
  /// <param name="newNode">The `NewNode` parameter.</param>
  /// <param name="inUndoRedo">The `InUndoRedo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartevents.nodeafterreplace?view=office-pia"/>
  public void NodeAfterReplace(ICustomXMLNode oldNode, ICustomXMLNode newNode, bool inUndoRedo);

  #endregion methods
}

