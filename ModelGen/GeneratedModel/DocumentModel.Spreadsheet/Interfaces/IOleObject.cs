namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLE Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IEmbeddedObjectProperties))]
public interface IOleObject // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLE ProgId
  /// </summary>
  public string? ProgId { get ; set; }
  
  /// <summary>
  /// Data or View Aspect
  /// </summary>
  public DataViewAspect? DataOrViewAspect { get ; set; }
  
  /// <summary>
  /// OLE Link Moniker
  /// </summary>
  public string? Link { get ; set; }
  
  /// <summary>
  /// OLE Update
  /// </summary>
  public OleUpdate? OleUpdate { get ; set; }
  
  /// <summary>
  /// Auto Load
  /// </summary>
  public bool? AutoLoad { get ; set; }
  
  /// <summary>
  /// Shape Id
  /// </summary>
  public uint? ShapeId { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// EmbeddedObjectProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public IEmbeddedObjectProperties? EmbeddedObjectProperties { get ; set; }
  
}
