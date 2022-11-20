namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Simple Positioning Coordinates.
/// </summary>
public interface ISimplePosition // : DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public long? X { get ; set; }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public long? Y { get ; set; }
  
}
