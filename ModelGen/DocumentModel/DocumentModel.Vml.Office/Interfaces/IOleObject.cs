namespace DocumentModel.Vml.Office;

/// <summary>
/// Embedded OLE Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ILinkType))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ILockedField))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IFieldCodes))]
public interface IOleObject // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public OleValues? Type { get ; set; }
  
  /// <summary>
  /// OLE Object Application
  /// </summary>
  public string? ProgId { get ; set; }
  
  /// <summary>
  /// OLE Object Shape
  /// </summary>
  public string? ShapeId { get ; set; }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public OleDrawAspectValues? DrawAspect { get ; set; }
  
  /// <summary>
  /// OLE Object Unique ID
  /// </summary>
  public string? ObjectId { get ; set; }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public string? Id { get ; set; }
  
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
