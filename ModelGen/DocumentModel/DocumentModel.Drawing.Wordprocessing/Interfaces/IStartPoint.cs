namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Wrapping Polygon Start.
/// </summary>
public interface IStartPoint // : DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType
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
