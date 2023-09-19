namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the visual properties, associated server application and refresh mode of an embedded linked object.
/// </summary>
public partial class ObjectLink
{
  
  /// <summary>
  ///   updateMode
  /// </summary>
  [SchemaAttr("w:updateMode")]
  public DocumentModel.Wordprocessing.ObjectUpdateMode? UpdateMode { get; set; }
  
  
  /// <summary>
  ///   lockedField
  /// </summary>
  [SchemaAttr("w:lockedField")]
  public Boolean? LockedField { get; set; }
  
  
  /// <summary>
  ///   Specifies how the object is represented visually in the application.
  /// </summary>
  [SchemaAttr("w:drawAspect")]
  public DocumentModel.Wordprocessing.ObjectDrawAspect? drawAspect { get; set; }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   progId
  /// </summary>
  [SchemaAttr("w:progId")]
  public String? ProgId { get; set; }
  
  
  /// <summary>
  ///   shapeId
  /// </summary>
  [SchemaAttr("w:shapeId")]
  public String? ShapeId { get; set; }
  
  
  /// <summary>
  ///   fieldCodes
  /// </summary>
  [SchemaAttr("w:fieldCodes")]
  public String? FieldCodes { get; set; }
  
}
