namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the DocEvents Class.
/// </summary>
public interface IDocEvents // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// EventDocNewXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocNewXsdString { get ; set; }
  
  /// <summary>
  /// EventDocOpenXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocOpenXsdString { get ; set; }
  
  /// <summary>
  /// EventDocCloseXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocCloseXsdString { get ; set; }
  
  /// <summary>
  /// EventDocSyncXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocSyncXsdString { get ; set; }
  
  /// <summary>
  /// EventDocXmlAfterInsertXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocXmlAfterInsertXsdString { get ; set; }
  
  /// <summary>
  /// EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocXmlBeforeDeleteXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlAfterInsertXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocContentControlAfterInsertXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocContentControlBeforeDeleteXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlOnExistXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocContentControlOnExistXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlOnEnterXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocContentControlOnEnterXsdString { get ; set; }
  
  /// <summary>
  /// EventDocStoreUpdateXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocStoreUpdateXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlUpdateXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocContentControlUpdateXsdString { get ; set; }
  
  /// <summary>
  /// EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EventDocBuildingBlockAfterInsertXsdString { get ; set; }
  
}
