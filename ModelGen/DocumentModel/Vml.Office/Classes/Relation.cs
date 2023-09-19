namespace DocumentModel.Vml.Office;


/// <summary>
///   Diagram Relationship.
/// </summary>
public partial class Relation
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Diagram Relationship Source Shape
  /// </summary>
  [SchemaAttr("idsrc")]
  public String? SourceId { get; set; }
  
  
  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  [SchemaAttr("iddest")]
  public String? DestinationId { get; set; }
  
  
  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  [SchemaAttr("idcntr")]
  public String? CenterShapeId { get; set; }
  
}
