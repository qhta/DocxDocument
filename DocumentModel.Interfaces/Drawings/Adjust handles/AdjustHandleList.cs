namespace DocumentModel.Drawings;

/// <summary>
/// Represents a list of shape adjust handles, providing access to both XY and polar adjustment handles for shape manipulation.
/// </summary>
public interface AdjustHandleList
{
  /// <summary>
  /// Gets or sets the XY adjust handle, which provides guides and limits for horizontal and vertical adjustments.
  /// </summary>
  public AdjustHandleXY? AdjustHandleXY { get; set; }

  /// <summary>
  /// Gets or sets the polar adjust handle, which provides guides and limits for radial and angular adjustments.
  /// </summary>
  public AdjustHandlePolar? AdjustHandlePolar { get; set; }
}