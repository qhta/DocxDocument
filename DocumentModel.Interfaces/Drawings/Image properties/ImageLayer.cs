namespace DocumentModel.Drawings;

/// <summary>
/// Represents an image layer, which includes an embedded image reference, a collection of image effects, and additional properties.
/// </summary>
public interface ImageLayer : IElementCollection<ImageEffect>, ExtendableElement
{
  /// <summary>
  /// Embedded image relationship ID.
  /// </summary>
  public string? Embed { get; set; }

  /// <summary>
  /// Name of the image layer.
  /// </summary>
  public string? Name { get; set; }
}