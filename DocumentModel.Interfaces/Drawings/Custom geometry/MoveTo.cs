namespace DocumentModel.Drawings;

/// <summary>
///   Represents a command to move the current path to a specified point without drawing a line.
/// </summary>
public interface MoveTo
{
  /// <summary>
  ///   Destination point for the move operation.
  /// </summary>
  public AdjustPoint2DType? Point { get; set; }
}