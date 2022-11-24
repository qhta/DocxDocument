namespace DocumentModel.Vml.Office;

/// <summary>
/// Diagram Relationship.
/// </summary>
public interface IRelation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Source Shape
  /// </summary>
  public String? SourceId { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  public String? DestinationId { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  public String? CenterShapeId { get ; set; }
  
}
