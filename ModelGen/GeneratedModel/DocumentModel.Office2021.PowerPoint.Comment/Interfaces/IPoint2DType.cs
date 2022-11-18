namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public interface IPoint2DType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
