namespace DocumentModel.Vml.Office;


/// <summary>
///   Embedded OLE Object.
/// </summary>
public partial class OleObject
{
  
  /// <summary>
  ///   OLE Object Type
  /// </summary>
  public DocumentModel.Vml.Office.OleKind? Type { get; set; }
  
  
  /// <summary>
  ///   OLE Object Application
  /// </summary>
  public String? ProgId { get; set; }
  
  
  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  public String? ShapeId { get; set; }
  
  
  /// <summary>
  ///   OLE Object Representation
  /// </summary>
  public DocumentModel.Vml.Office.OleDrawAspectKind? DrawAspect { get; set; }
  
  
  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  public String? ObjectId { get; set; }
  
  
  /// <summary>
  ///   Relationship
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   OLE Update Mode
  /// </summary>
  public DocumentModel.Vml.Office.OleUpdateMode? UpdateMode { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  public DocumentModel.Vml.Office.LinkType? LinkType { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  public DocumentModel.Vml.Office.LockedField? LockedField { get; set; }
  
  
  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  public DocumentModel.Vml.Office.FieldCodes? FieldCodes { get; set; }
  
}
