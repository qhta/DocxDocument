using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Transform2D Class.
/// </summary>
public class Transform2D: ModelElement
{
  /// <summary>
  ///   Rotation
  /// </summary>
  public Int32? Rotation { get; set; }
  /// <summary>
  ///   Horizontal Flip
  /// </summary>
  public bool? HorizontalFlip { get; set; }
  /// <summary>
  ///   Vertical Flip
  /// </summary>
  public bool? VerticalFlip { get; set; }
  /// <summary>
  ///   Offset.
  /// </summary>
  public Point2DType? Offset { get; set; }
  /// <summary>
  ///   Extents.
  /// </summary>
  public PositiveSize2DType? Extents { get; set; }
}