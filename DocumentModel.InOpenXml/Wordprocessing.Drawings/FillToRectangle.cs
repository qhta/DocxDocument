namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the rectangle area to which a fill is applied in a Wordprocessing drawing element.
/// This interface provides properties for specifying the left, top, right, and bottom boundaries of the fill area, allowing precise control over the fill's position and dimensions within the drawing.
/// </summary>
public interface FillToRectangle
{
  /// <summary>
  /// The left boundary of the fill rectangle, representing the distance from the left edge of the drawing element.
  /// </summary>
  public Int32? Left { get; set; }

  /// <summary>
  /// The top boundary of the fill rectangle, representing the distance from the top edge of the drawing element.
  /// </summary>
  public Int32? Top { get; set; }

  /// <summary>
  /// The right boundary of the fill rectangle, representing the distance from the right edge of the drawing element.
  /// </summary>
  public Int32? Right { get; set; }

  /// <summary>
  /// The bottom boundary of the fill rectangle, representing the distance from the bottom edge of the drawing element.
  /// </summary>
  public Int32? Bottom { get; set; }
}