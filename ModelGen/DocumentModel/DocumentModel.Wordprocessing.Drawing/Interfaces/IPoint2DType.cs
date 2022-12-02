namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public interface IPoint2DType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public Int64? X { get ; set; }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public Int64? Y { get ; set; }
  
}
