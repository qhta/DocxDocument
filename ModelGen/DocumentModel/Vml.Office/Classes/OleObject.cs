namespace DocumentModel.Vml.Office;


/// <summary>
///   Embedded OLE Object.
/// </summary>
public partial class OleObject
{
  
  /// <summary>
  ///   OLE Object Type
  /// </summary>
  [SchemaAttr("Type")]
  public DocumentModel.Vml.Office.OleValues? Type { get; set; }
  
  
  /// <summary>
  ///   OLE Object Application
  /// </summary>
  [SchemaAttr("ProgID")]
  public String? ProgId { get; set; }
  
  
  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  [SchemaAttr("ShapeID")]
  public String? ShapeId { get; set; }
  
  
  /// <summary>
  ///   OLE Object Representation
  /// </summary>
  [SchemaAttr("DrawAspect")]
  public DocumentModel.Vml.Office.OleDrawAspectValues? DrawAspect { get; set; }
  
  
  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  [SchemaAttr("ObjectID")]
  public String? ObjectId { get; set; }
  
  
  /// <summary>
  ///   Relationship
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   OLE Update Mode
  /// </summary>
  [SchemaAttr("UpdateMode")]
  public DocumentModel.Vml.Office.OleUpdateModeValues? UpdateMode { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  public String? LinkType { get; set; }
  
  
  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  public String? LockedField { get; set; }
  
  
  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  public String? FieldCodes { get; set; }
  
}
