namespace DocumentModel.Drawings;

/// <summary>
/// Represents image properties for a drawing element, including image layers, adjustments, effects, and extensions.
/// </summary>
public interface ImageProperties: ExtendableElement
{
  /// <summary>
  /// Image layer, which defines the base image and its properties.
  /// </summary>
  public ImageLayer? ImageLayer { get; set; }

  /// <summary>
  /// Brightness and contrast adjustment for the image.
  /// </summary>
  public BrightnessContrast? BrightnessContrast { get; set; }

  /// <summary>
  /// Image effect applied to the image.
  /// </summary>
  public ImageEffect? ImageEffect { get; set; }
}