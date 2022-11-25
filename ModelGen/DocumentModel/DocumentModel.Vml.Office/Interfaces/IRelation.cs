namespace DocumentModel.Vml.Office;

/// <summary>
/// Diagram Relationship.
/// </summary>
public interface IRelation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Source Shape
  /// </summary>
  public System.String? SourceId { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  public System.String? DestinationId { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  public System.String? CenterShapeId { get ; set; }
  
}
