namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocEvents Class.
/// </summary>
public partial interface DocEvents
{
  /// <summary>
  /// EventDocNewXsdString.
  /// </summary>
  public String? EventDocNewXsdString { get; set; }
  
  /// <summary>
  /// EventDocOpenXsdString.
  /// </summary>
  public String? EventDocOpenXsdString { get; set; }
  
  /// <summary>
  /// EventDocCloseXsdString.
  /// </summary>
  public String? EventDocCloseXsdString { get; set; }
  
  /// <summary>
  /// EventDocSyncXsdString.
  /// </summary>
  public String? EventDocSyncXsdString { get; set; }
  
  /// <summary>
  /// EventDocXmlAfterInsertXsdString.
  /// </summary>
  public String? EventDocXmlAfterInsertXsdString { get; set; }
  
  /// <summary>
  /// EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  public String? EventDocXmlBeforeDeleteXsdString { get; set; }
  
  /// <summary>
  /// EventDocContentControlAfterInsertXsdString.
  /// </summary>
  public String? EventDocContentControlAfterInsertXsdString { get; set; }
  
  /// <summary>
  /// EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  public String? EventDocContentControlBeforeDeleteXsdString { get; set; }
  
  /// <summary>
  /// EventDocContentControlOnExistXsdString.
  /// </summary>
  public String? EventDocContentControlOnExistXsdString { get; set; }
  
  /// <summary>
  /// EventDocContentControlOnEnterXsdString.
  /// </summary>
  public String? EventDocContentControlOnEnterXsdString { get; set; }
  
  /// <summary>
  /// EventDocStoreUpdateXsdString.
  /// </summary>
  public String? EventDocStoreUpdateXsdString { get; set; }
  
  /// <summary>
  /// EventDocContentControlUpdateXsdString.
  /// </summary>
  public String? EventDocContentControlUpdateXsdString { get; set; }
  
  /// <summary>
  /// EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  public String? EventDocBuildingBlockAfterInsertXsdString { get; set; }
  
}
