namespace DocumentModel.Vml.Office;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public interface IOleObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public OleValues? Type { get ; set; }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  public String? ProgId { get ; set; }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  public String? ShapeId { get ; set; }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public OleDrawAspectValues? DrawAspect { get ; set; }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  public String? ObjectId { get ; set; }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  public OleUpdateModeValues? UpdateMode { get ; set; }
  
  /// <summary>
  /// Embedded Object Alternate Image Request.
  /// </summary>
  public ILinkType? LinkType { get ; set; }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  public ILockedField? LockedField { get ; set; }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  public IFieldCodes? FieldCodes { get ; set; }
  
}
