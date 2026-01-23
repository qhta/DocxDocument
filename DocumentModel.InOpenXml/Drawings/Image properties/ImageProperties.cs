namespace DocumentModel.Drawings;

/// <summary>
/// Represents image properties for a drawing element, including image layers, adjustments, effects, and extensions.
/// </summary>
public class ImageProperties: ModelElement<DXO10D.ImageProperties>, IExtendableElement
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

  /// <summary>
  /// List of visual effects applied to the image.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}