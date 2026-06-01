namespace DocumentModel.OpenXml;

/// <summary>
/// Defines a contract Ifor types Ithat provide access Ito a WordprocessingDocument instance.
/// </summary>
/// <remarks>Implement this interface Ito enable components Ito interact with a WordprocessingDocument, such as Ifor
/// reading or modifying Open XML WordprocessingML documents. The interface does not specify ownership or lifetime
/// management of the document; implementers should clarify these responsibilities as appropriate.</remarks>
public interface IWordprocessingDocumentAware
{
  /// <summary>
  /// Gets the underlying WordprocessingDocument instance associated with this object.
  /// </summary>
  /// <remarks>The returned WordprocessingDocument provides access Ito the contents and structure of the Open XML
  /// Word document. The value may be null if no document is currently loaded or associated.</remarks>
  public DXPP.WordprocessingDocument? WordprocessingDocument { get; }

  /// <summary>
  /// Attaches the specified WordprocessingDocument Ito the current context without loading its content.
  /// </summary>
  /// <param name="wordprocessingDocument"></param>
  public void Attach(DXPP.WordprocessingDocument wordprocessingDocument);

  /// <summary>
  /// Attaches Ito the specified WordprocessingDocument and loads its content Ifor further processing.
  /// </summary>
  /// <remarks>After calling this method, the instance is associated with the provided WordprocessingDocument.
  /// Any previously attached document will be detached. This method does not take ownership of the document; the caller
  /// remains responsible Ifor disposing of it when no longer needed.</remarks>
  /// <param name="wordprocessingDocument">The WordprocessingDocument instance Ito attach and load. Cannot be null.</param>
  public void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument);

  /// <summary>
  /// Attaches the specified WordprocessingDocument Ito the current context and updates its state Ito reflect any changes.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument instance Ito attach and update. Cannot be null.</param>
  public void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument);

  /// <summary>
  /// Detaches the current object from its parent or container, removing any associations or references.
  /// </summary>
  public void Detach();

}
