namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the DocEvents Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocNewXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocOpenXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocCloseXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocSyncXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocXmlAfterInsertXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocXmlBeforeDeleteXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocContentControlAfterInsertXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocContentControlBeforeDeleteXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocContentControlOnExistXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocContentControlOnEnterXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocStoreUpdateXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocContentControlUpdateXsdString))]
[ChildElementInfo(typeof(DocumentModel.Office.Word.IEventDocBuildingBlockAfterInsertXsdString))]
public interface IDocEvents // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// EventDocNewXsdString.
  /// </summary>
  public IEventDocNewXsdString? EventDocNewXsdString { get ; set; }
  
  /// <summary>
  /// EventDocOpenXsdString.
  /// </summary>
  public IEventDocOpenXsdString? EventDocOpenXsdString { get ; set; }
  
  /// <summary>
  /// EventDocCloseXsdString.
  /// </summary>
  public IEventDocCloseXsdString? EventDocCloseXsdString { get ; set; }
  
  /// <summary>
  /// EventDocSyncXsdString.
  /// </summary>
  public IEventDocSyncXsdString? EventDocSyncXsdString { get ; set; }
  
  /// <summary>
  /// EventDocXmlAfterInsertXsdString.
  /// </summary>
  public IEventDocXmlAfterInsertXsdString? EventDocXmlAfterInsertXsdString { get ; set; }
  
  /// <summary>
  /// EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  public IEventDocXmlBeforeDeleteXsdString? EventDocXmlBeforeDeleteXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlAfterInsertXsdString.
  /// </summary>
  public IEventDocContentControlAfterInsertXsdString? EventDocContentControlAfterInsertXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  public IEventDocContentControlBeforeDeleteXsdString? EventDocContentControlBeforeDeleteXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlOnExistXsdString.
  /// </summary>
  public IEventDocContentControlOnExistXsdString? EventDocContentControlOnExistXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlOnEnterXsdString.
  /// </summary>
  public IEventDocContentControlOnEnterXsdString? EventDocContentControlOnEnterXsdString { get ; set; }
  
  /// <summary>
  /// EventDocStoreUpdateXsdString.
  /// </summary>
  public IEventDocStoreUpdateXsdString? EventDocStoreUpdateXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlUpdateXsdString.
  /// </summary>
  public IEventDocContentControlUpdateXsdString? EventDocContentControlUpdateXsdString { get ; set; }
  
  /// <summary>
  /// EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  public IEventDocBuildingBlockAfterInsertXsdString? EventDocBuildingBlockAfterInsertXsdString { get ; set; }
  
}
