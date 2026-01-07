namespace DocumentModel.Drawings;

/// <summary>
/// Represents a foreground mark defined by two coordinate points, typically used to specify areas to retain during background removal processing.
/// </summary>
public interface ForegroundMark: CollectionItem
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