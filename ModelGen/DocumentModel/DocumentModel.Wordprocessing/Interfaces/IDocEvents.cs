namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocEvents Class.
/// </summary>
public interface IDocEvents // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// EventDocNewXsdString.
  /// </summary>
  public System.String? EventDocNewXsdString { get ; set; }
  
  /// <summary>
  /// EventDocOpenXsdString.
  /// </summary>
  public System.String? EventDocOpenXsdString { get ; set; }
  
  /// <summary>
  /// EventDocCloseXsdString.
  /// </summary>
  public System.String? EventDocCloseXsdString { get ; set; }
  
  /// <summary>
  /// EventDocSyncXsdString.
  /// </summary>
  public System.String? EventDocSyncXsdString { get ; set; }
  
  /// <summary>
  /// EventDocXmlAfterInsertXsdString.
  /// </summary>
  public System.String? EventDocXmlAfterInsertXsdString { get ; set; }
  
  /// <summary>
  /// EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  public System.String? EventDocXmlBeforeDeleteXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlAfterInsertXsdString.
  /// </summary>
  public System.String? EventDocContentControlAfterInsertXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  public System.String? EventDocContentControlBeforeDeleteXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlOnExistXsdString.
  /// </summary>
  public System.String? EventDocContentControlOnExistXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlOnEnterXsdString.
  /// </summary>
  public System.String? EventDocContentControlOnEnterXsdString { get ; set; }
  
  /// <summary>
  /// EventDocStoreUpdateXsdString.
  /// </summary>
  public System.String? EventDocStoreUpdateXsdString { get ; set; }
  
  /// <summary>
  /// EventDocContentControlUpdateXsdString.
  /// </summary>
  public System.String? EventDocContentControlUpdateXsdString { get ; set; }
  
  /// <summary>
  /// EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  public System.String? EventDocBuildingBlockAfterInsertXsdString { get ; set; }
  
}
