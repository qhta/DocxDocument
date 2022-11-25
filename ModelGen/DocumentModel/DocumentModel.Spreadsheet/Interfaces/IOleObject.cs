namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLE Object.
/// </summary>
public interface IOleObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLE ProgId
  /// </summary>
  public System.String? ProgId { get ; set; }
  
  /// <summary>
  /// Data or View Aspect
  /// </summary>
  public DocumentModel.Spreadsheet.DataViewAspectKind? DataOrViewAspect { get ; set; }
  
  /// <summary>
  /// OLE Link Moniker
  /// </summary>
  public System.String? Link { get ; set; }
  
  /// <summary>
  /// OLE Update
  /// </summary>
  public DocumentModel.Spreadsheet.OleUpdateKind? OleUpdate { get ; set; }
  
  /// <summary>
  /// Auto Load
  /// </summary>
  public System.Boolean? AutoLoad { get ; set; }
  
  /// <summary>
  /// Shape Id
  /// </summary>
  public System.UInt32? ShapeId { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// EmbeddedObjectProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IEmbeddedObjectProperties? EmbeddedObjectProperties { get ; set; }
  
}
