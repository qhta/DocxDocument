namespace DocumentModel.Drawings;

/// <summary>
/// Represents a compatibility extension, including a shape identifier.
/// </summary>
public class CompatExtension: ModelElement<DXO10D.CompatExtension>, IExtension
{
  /// <summary>
  /// Shape identifier.
  /// </summary>
  public string? ShapeId { get; set; }

  public string? Uri { get; set; }
}