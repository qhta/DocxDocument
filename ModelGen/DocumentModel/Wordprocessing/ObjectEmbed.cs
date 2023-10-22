namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the visual properties and associated server application of an embedded object.
/// </summary>
public partial class ObjectEmbed
{
  
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
