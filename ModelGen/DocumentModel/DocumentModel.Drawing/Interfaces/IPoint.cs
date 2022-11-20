namespace DocumentModel.Drawing;

/// <summary>
/// Move end point.
/// </summary>
public interface IPoint // : DocumentFormat.OpenXml.Drawing.AdjustPoint2DType
{
  /// <summary>
  /// X-Coordinate
  /// </summary>
  public string? X { get ; set; }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  public string? Y { get ; set; }
  
}
