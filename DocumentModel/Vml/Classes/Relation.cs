namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IDiagram Relationship.
/// </summary>
public class Relation: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   IDiagram Relationship ISource IShape
  /// </summary>
  public string? SourceId { get; set; }

  /// <summary>
  ///   IDiagram Relationship Destination IShape
  /// </summary>
  public string? DestinationId { get; set; }

  /// <summary>
  ///   IDiagram Relationship Center IShape
  /// </summary>
  public string? CenterShapeId { get; set; }
}
