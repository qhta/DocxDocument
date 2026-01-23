namespace DocumentModel.Drawings;

/// <summary>
/// Represents a background mark defined by two coordinate points, typically used to specify a rectangular region or line in the background.
/// </summary>
public class BackgroundMark: ModelElement<DXO10D.BackgroundMark>
{
  /// <summary>
  /// Gets or sets the X coordinate of the first point.
  /// </summary>
  public Int32? FirstXCoordinate { get; set; }

  /// <summary>
  /// Gets or sets the Y coordinate of the first point.
  /// </summary>
  public Int32? FirstYCoordinate { get; set; }

  /// <summary>
  /// Gets or sets the X coordinate of the second point.
  /// </summary>
  public Int32? SecondXCoordinate { get; set; }

  /// <summary>
  /// Gets or sets the Y coordinate of the second point.
  /// </summary>
  public Int32? SecondYCoordinate { get; set; }
}