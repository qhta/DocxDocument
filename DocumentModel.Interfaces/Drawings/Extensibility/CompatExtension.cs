namespace DocumentModel.Drawings;

/// <summary>
/// Represents a compatibility extension, including a shape identifier.
/// </summary>
public interface CompatExtension
{
  /// <summary>
  /// Shape identifier.
  /// </summary>
  public string? ShapeId { get; set; }
}