namespace DocumentModel.Drawing;

/// <summary>
/// Position.
/// </summary>
public interface IPosition // : DocumentFormat.OpenXml.Drawing.AdjustPoint2DType
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
