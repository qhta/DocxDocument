namespace DocumentModel.Vml;

/// <summary>
///   Diagram Relationship.
/// </summary>
public class Relation: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Diagram Relationship Source Shape
  /// </summary>
  public string? SourceId { get; set; }
  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  public string? DestinationId { get; set; }
  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  public string? CenterShapeId { get; set; }
}