namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the Connection Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IDataFeedProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IModelTextProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IOleDbPrpoperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IRangeProperties))]
public interface IConnection // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// model, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Model { get ; set; }
  
  /// <summary>
  /// excludeFromRefreshAll, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? ExcludeFromRefreshAll { get ; set; }
  
  /// <summary>
  /// autoDelete, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? AutoDelete { get ; set; }
  
  /// <summary>
  /// usedByAddin, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? UsedByAddin { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Office2013.Excel.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// ModelTextProperties.
  /// </summary>
  public IModelTextProperties? ModelTextProperties { get ; set; }
  
  /// <summary>
  /// RangeProperties.
  /// </summary>
  public DocumentModel.Office2013.Excel.IRangeProperties? RangeProperties { get ; set; }
  
  /// <summary>
  /// OleDbPrpoperties.
  /// </summary>
  public IOleDbPrpoperties? OleDbPrpoperties { get ; set; }
  
  /// <summary>
  /// DataFeedProperties.
  /// </summary>
  public IDataFeedProperties? DataFeedProperties { get ; set; }
  
}
