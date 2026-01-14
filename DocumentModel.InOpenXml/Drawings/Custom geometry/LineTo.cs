namespace DocumentModel.Drawings;

/// <summary>
///   Represents a command to draw a straight line to a specified point.
/// </summary>
public interface LineTo
{
  /// <summary>
  ///   End point of the line.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}