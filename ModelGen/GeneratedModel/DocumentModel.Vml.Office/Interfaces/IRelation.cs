namespace DocumentModel.Vml.Office;

/// <summary>
/// Diagram Relationship.
/// </summary>
public interface IRelation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Source Shape
  /// </summary>
  public string? SourceId { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Destination Shape
  /// </summary>
  public string? DestinationId { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Center Shape
  /// </summary>
  public string? CenterShapeId { get ; set; }
  
}
