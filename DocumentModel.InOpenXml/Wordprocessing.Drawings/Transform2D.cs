using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a 2D transformation applied to a drawing element in a Wordprocessing document.
/// This interface provides properties for configuring rotation, flipping, offset, and extents, enabling advanced positioning and sizing of graphical objects.
/// </summary>
public class Transform2D: ModelElement
{

  /// <summary>
  /// The rotation angle applied to the drawing element, specified in degrees.
  /// </summary>
  public Int32? Rotation { get; set; }

  /// <summary>
  /// Indicates whether the drawing element is flipped horizontally.
  /// </summary>
  public bool? HorizontalFlip { get; set; }

  /// <summary>
  /// Indicates whether the drawing element is flipped vertically.
  /// </summary>
  public bool? VerticalFlip { get; set; }

  /// <summary>
  /// The offset position of the drawing element, specifying the x and y coordinates relative to the parent container.
  /// </summary>
  public Point2DType? Offset { get; set; }

  /// <summary>
  /// The extents of the drawing element, specifying the width and height.
  /// </summary>
  public PositiveSize2DType? Extents { get; set; }
}