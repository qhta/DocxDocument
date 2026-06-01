namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2?view=word-pia"/>
public partial class DocumentEvents2
{
  /// <summary>
  /// Executes the new operation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.new?view=word-pia"/>
  public void New() { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the open operation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.open?view=word-pia"/>
  public void Open() { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the close operation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.close?view=word-pia"/>
  public void Close() { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the sync operation.
  /// </summary>
  /// <param name="SyncEventType">Specifies the sync event type.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.sync?view=word-pia"/>
  public void Sync(Core.SyncEventType SyncEventType) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the xmlafter insert operation.
  /// </summary>
  /// <param name="NewXMLNode">Specifies the new xmlnode.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.xmlafterinsert?view=word-pia"/>
  public void XMLAfterInsert(XMLNode NewXMLNode, bool InUndoRedo) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the xmlbefore delete operation.
  /// </summary>
  /// <param name="DeletedRange">Specifies the deleted range.</param>
  /// <param name="OldXMLNode">Specifies the old xmlnode.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.xmlbeforedelete?view=word-pia"/>
  public void XMLBeforeDelete(Range DeletedRange, XMLNode OldXMLNode, bool InUndoRedo) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the content control after add operation.
  /// </summary>
  /// <param name="NewContentControl">Specifies the new content control.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.contentcontrolafteradd?view=word-pia"/>
  public void ContentControlAfterAdd(ContentControl NewContentControl, bool InUndoRedo) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the content control before delete operation.
  /// </summary>
  /// <param name="OldContentControl">Specifies the old content control.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.contentcontrolbeforedelete?view=word-pia"/>
  public void ContentControlBeforeDelete(ContentControl OldContentControl, bool InUndoRedo) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the content control on exit operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  /// <param name="Cancel">Specifies whether cancel.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.contentcontrolonexit?view=word-pia"/>
  public void ContentControlOnExit(ContentControl ContentControl, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the content control on enter operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.contentcontrolonenter?view=word-pia"/>
  public void ContentControlOnEnter(ContentControl ContentControl) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the content control before store update operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  /// <param name="Content">Specifies the content.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.contentcontrolbeforestoreupdate?view=word-pia"/>
  public void ContentControlBeforeStoreUpdate(ContentControl ContentControl, string Content) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the content control before content update operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  /// <param name="Content">Specifies the content.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.contentcontrolbeforecontentupdate?view=word-pia"/>
  public void ContentControlBeforeContentUpdate(ContentControl ContentControl, string Content) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the building block insert operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Category">Specifies the category.</param>
  /// <param name="BlockType">Specifies the block type.</param>
  /// <param name="Template">Specifies the template.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2.buildingblockinsert?view=word-pia"/>
  public void BuildingBlockInsert(Range Range, string Name, string Category, string BlockType, string Template) { throw new NotImplementedException(); }
}
