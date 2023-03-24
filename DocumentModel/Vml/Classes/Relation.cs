namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  public String? SourceId { get; set; }

  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  public String? DestinationId { get; set; }

  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  public String? CenterShapeId { get; set; }
}