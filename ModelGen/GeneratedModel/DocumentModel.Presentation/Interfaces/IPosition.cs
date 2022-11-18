namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Position Class.
/// </summary>
public interface IPosition // : DocumentFormat.OpenXml.Presentation.Point2DType
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
