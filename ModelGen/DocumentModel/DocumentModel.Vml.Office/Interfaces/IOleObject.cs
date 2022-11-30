namespace DocumentModel.Vml.Office;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public interface IOleObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public DocumentModel.Vml.Office.OleKind? Type { get ; set; }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  public System.String? ProgId { get ; set; }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public DocumentModel.Vml.Office.OleDrawAspectKind? DrawAspect { get ; set; }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  public System.String? ObjectId { get ; set; }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  public DocumentModel.Vml.Office.OleUpdateMode? UpdateMode { get ; set; }
  
  /// <summary>
  /// Embedded Object Alternate Image Request.
  /// </summary>
  public System.String? LinkType { get ; set; }
  
  /// <summary>
  /// Embedded Object Cannot Be Refreshed.
  /// </summary>
  public System.String? LockedField { get ; set; }
  
  /// <summary>
  /// WordprocessingML Field Switches.
  /// </summary>
  public System.String? FieldCodes { get ; set; }
  
}
