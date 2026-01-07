namespace DocumentModel.Drawings;

/// <summary>
/// Represents a compatibility extension, including a shape identifier.
/// </summary>
public interface CompatExtension: Extension
{
  /// <summary>
  /// Shape identifier.
  /// </summary>
  public string? ShapeId { get; set; }
}