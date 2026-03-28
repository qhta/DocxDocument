namespace DocumentModel.Interop;

public partial interface DocumentEvents2
{
  /// <summary>
  /// Executes the new operation.
  /// </summary>
  public void New();

  /// <summary>
  /// Executes the open operation.
  /// </summary>
  public void Open();

  /// <summary>
  /// Executes the close operation.
  /// </summary>
  public void Close();

  /// <summary>
  /// Executes the sync operation.
  /// </summary>
  /// <param name="SyncEventType">Specifies the sync event type.</param>
  public void Sync(Core.MsoSyncEventType SyncEventType);

  /// <summary>
  /// Executes the xmlafter insert operation.
  /// </summary>
  /// <param name="NewXMLNode">Specifies the new xmlnode.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  public void XMLAfterInsert(XMLNode NewXMLNode, bool InUndoRedo);

  /// <summary>
  /// Executes the xmlbefore delete operation.
  /// </summary>
  /// <param name="DeletedRange">Specifies the deleted range.</param>
  /// <param name="OldXMLNode">Specifies the old xmlnode.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  public void XMLBeforeDelete(Range DeletedRange, XMLNode OldXMLNode, bool InUndoRedo);

  /// <summary>
  /// Executes the content control after add operation.
  /// </summary>
  /// <param name="NewContentControl">Specifies the new content control.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  public void ContentControlAfterAdd(ContentControl NewContentControl, bool InUndoRedo);

  /// <summary>
  /// Executes the content control before delete operation.
  /// </summary>
  /// <param name="OldContentControl">Specifies the old content control.</param>
  /// <param name="InUndoRedo">Specifies whether in undo redo.</param>
  public void ContentControlBeforeDelete(ContentControl OldContentControl, bool InUndoRedo);

  /// <summary>
  /// Executes the content control on exit operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  /// <param name="Cancel">Specifies whether cancel.</param>
  public void ContentControlOnExit(ContentControl ContentControl, ref bool Cancel);

  /// <summary>
  /// Executes the content control on enter operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  public void ContentControlOnEnter(ContentControl ContentControl);

  /// <summary>
  /// Executes the content control before store update operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  /// <param name="Content">Specifies the content.</param>
  public void ContentControlBeforeStoreUpdate(ContentControl ContentControl, string Content);

  /// <summary>
  /// Executes the content control before content update operation.
  /// </summary>
  /// <param name="ContentControl">Specifies the content control.</param>
  /// <param name="Content">Specifies the content.</param>
  public void ContentControlBeforeContentUpdate(ContentControl ContentControl, string Content);

  /// <summary>
  /// Executes the building block insert operation.
  /// </summary>
  /// <param name="Range">Specifies the range.</param>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Category">Specifies the category.</param>
  /// <param name="BlockType">Specifies the block type.</param>
  /// <param name="Template">Specifies the template.</param>
  public void BuildingBlockInsert(Range Range, string Name, string Category, string BlockType, string Template);
}
