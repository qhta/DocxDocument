namespace DocumentModel.Drawings;

/// <summary>
/// Represents a blip fill, providing properties for image fill effects in drawing elements.
/// </summary>
public interface BlipFill: Fill
{
  /// <summary>
  /// DPI (dots per inch) setting for the blip fill.
  /// </summary>
  public UInt32? Dpi { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the fill rotates with the shape.
  /// </summary>
  public bool? RotateWithShape { get; set; }

  /// <summary>
  /// Blip (image) used for the fill.
  /// </summary>
  public Blip? Blip { get; set; }

  /// <summary>
  /// Source rectangle, which defines the portion of the image to use.
  /// </summary>
  public RelativeRectangleType? SourceRectangle { get; set; }

  /// <summary>
  /// Tile settings for the blip fill.
  /// </summary>
  public Tile? Tile { get; set; }

  /// <summary>
  /// Stretch settings for the blip fill.
  /// </summary>
  public Stretch? Stretch { get; set; }
}