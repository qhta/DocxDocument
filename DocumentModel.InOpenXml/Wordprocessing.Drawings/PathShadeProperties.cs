namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the properties for a path-based gradient shade applied to a drawing element in a Wordprocessing document.
/// This interface provides configuration for the gradient path type and the rectangle area to which the fill is applied, enabling advanced gradient effects and precise control over fill positioning.
/// </summary>
public class PathShadeProperties: ModelElement<DXO10W.PathShadeProperties>
{
  /// <summary>
  /// The type of path used for the gradient shade, specifying the shape and direction of the gradient fill.
  /// </summary>
  public PathShadeKind? Path { get; set; }

  /// <summary>
  /// The rectangle area to which the gradient fill is applied, allowing precise definition of the fill boundaries.
  /// </summary>
  public FillToRectangle? FillToRectangle { get; set; }
}