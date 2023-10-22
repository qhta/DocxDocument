namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the visual properties, associated server application and refresh mode of an embedded linked object.
/// </summary>
public partial class ObjectLink
{
  
  /// <summary>
  ///   lockedField
  /// </summary>
  public Boolean? LockedField { get; set; }
  
  
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
