namespace DocumentModel.Presentation;

/// <summary>
/// View Origin.
/// </summary>
public interface IOrigin // : DocumentFormat.OpenXml.Presentation.Point2DType
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
