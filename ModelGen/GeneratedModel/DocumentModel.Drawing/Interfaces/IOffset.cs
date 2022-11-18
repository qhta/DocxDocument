namespace DocumentModel.Drawing;

/// <summary>
/// Offset.
/// </summary>
public interface IOffset // : DocumentFormat.OpenXml.Drawing.Point2DType
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
