namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public interface IPoint2DType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public System.Int64? X { get ; set; }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public System.Int64? Y { get ; set; }
  
}
