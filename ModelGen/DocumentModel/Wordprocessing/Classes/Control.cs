namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Control Class.
/// </summary>
public partial class Control
{
  
  /// <summary>
  ///   Unique Name for Embedded Control
  /// </summary>
  [SchemaAttr("w:name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Associated VML Data Reference
  /// </summary>
  [SchemaAttr("w:shapeid")]
  public String? ShapeId { get; set; }
  
  
  /// <summary>
  ///   Embedded Control Properties Relationship Reference
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
}
