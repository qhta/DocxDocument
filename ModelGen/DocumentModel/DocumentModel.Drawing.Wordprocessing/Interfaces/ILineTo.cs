namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Wrapping Polygon Line End Position.
/// </summary>
public interface ILineTo // : DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType
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
