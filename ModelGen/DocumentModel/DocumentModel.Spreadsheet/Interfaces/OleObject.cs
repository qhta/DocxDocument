namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLE Object.
/// </summary>
public interface OleObject // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// OLE ProgId
  /// </summary>
  public String? ProgId { get ; set; }
  
  /// <summary>
  /// Data or View Aspect
  /// </summary>
  public DataViewAspectKind? DataOrViewAspect { get ; set; }
  
  /// <summary>
  /// OLE Link Moniker
  /// </summary>
  public String? Link { get ; set; }
  
  /// <summary>
  /// OLE Update
  /// </summary>
  public OleUpdateKind? OleUpdate { get ; set; }
  
  /// <summary>
  /// Auto Load
  /// </summary>
  public Boolean? AutoLoad { get ; set; }
  
  /// <summary>
  /// Shape Id
  /// </summary>
  public UInt32? ShapeId { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// EmbeddedObjectProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public EmbeddedObjectProperties? EmbeddedObjectProperties { get ; set; }
  
}
