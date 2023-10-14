namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the visual properties, associated server application and refresh mode of an embedded linked object.
/// </summary>
public partial class ObjectLink
{
  
  /// <summary>
  ///   updateMode
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectUpdateMode? UpdateMode { get; set; }
  
  
  /// <summary>
  ///   lockedField
  /// </summary>
  public Boolean? LockedField { get; set; }
  
  
  /// <summary>
  ///   Specifies how the object is represented visually in the application.
  /// </summary>
  public DocumentModel.Wordprocessing.ObjectDrawAspect? drawAspect { get; set; }
  
  
  /// <summary>
  ///   id
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   progId
  /// </summary>
  public String? ProgId { get; set; }
  
  
  /// <summary>
  ///   shapeId
  /// </summary>
  public String? ShapeId { get; set; }
  
  
  /// <summary>
  ///   fieldCodes
  /// </summary>
  public String? FieldCodes { get; set; }
  
}
