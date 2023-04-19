namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Control Class.
/// </summary>
public class Control: ModelElement, IEmbeddedObjectContent
{
  /// <summary>
  ///   Unique Name for Embedded Control
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Associated VML Data Reference
  /// </summary>
  public string? ShapeId { get; set; }

  /// <summary>
  ///   Embedded Control Properties Relationship Reference
  /// </summary>
  public string? Id { get; set; }
}